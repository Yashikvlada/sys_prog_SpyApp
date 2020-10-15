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
            //_procSpyApp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            _statsAppName = "SpyStats";
            string statsAppPath = thisAppPath + "\\" + _statsAppName + ".exe";
            _procStatsApp = new Process();
            _procStatsApp.StartInfo = new ProcessStartInfo(statsAppPath);
        }

        private void button_start_spy_Click(object sender, EventArgs e)
        {
            //тут запускаем SpyApp и передаем ему _selectedCommands

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

        private void checkBox_stats_on_CheckedChanged(object sender, EventArgs e)
        {
            //_spyInfo.WhereToWriteKeys = string.Empty;
            if (!checkBox_stats_on.Checked)
            {
                textBox_stats_keys.Text = string.Empty;
                textBox_stats_proc.Text = string.Empty;
            }
            button_stats_keys.Enabled = checkBox_stats_on.Checked;
            button_stats_proc.Enabled = checkBox_stats_on.Checked;
        }

        private void checkBox_mod_on_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_mod_on.Checked)
            {
                textBox_mod_report.Text = string.Empty;
                textBox_bad_apps.Text = string.Empty;
                textBox_bad_words.Text = string.Empty;
            }
            button_mod_path.Enabled = checkBox_mod_on.Checked;
            button_badApps_path.Enabled = checkBox_mod_on.Checked;
            button_badWords_path.Enabled = checkBox_mod_on.Checked;
        }

        private void radioButton_Disable_CheckedChanged(object sender, EventArgs e)
        {
            _spyInfo.IsCloseBadApp = radioButton_Disable.Checked;
        }

        private void radioButton_Statistics_CheckedChanged(object sender, EventArgs e)
        {
            _spyInfo.IsCloseBadApp = !radioButton_Statistics.Checked;
        }

        private void textBox_stats_keys_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToWriteKeys = textBox_stats_keys.Text;
        }

        private void textBox_mod_report_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToWriteWords = textBox_mod_report.Text;
        }

        private void textBox_bad_words_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToReadBadWords = textBox_bad_words.Text;
        }

        private void textBox_bad_apps_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToReadBadApps = textBox_bad_apps.Text;
        }
        private void textBox_stats_proc_TextChanged(object sender, EventArgs e)
        {
            _spyInfo.WhereToWriteProcs = textBox_stats_proc.Text;
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
                        case "button_stats_path":
                            textBox_stats_keys.Text=filePath;
                            break;
                        case "button_mod_path":
                            textBox_mod_report.Text = filePath;
                            ;
                            break;
                        case "button_badWords_path":
                            textBox_bad_words.Text = filePath;
                            ;
                            break;
                        case "button_badApps_path":
                            textBox_bad_apps.Text = filePath;
                            ;
                            break;
                    }
                }
            }
        }


    }
}
