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
        private List<ISpyCommand> _selectedCommands;
        private Process _procSpyApp;
        private string _spyAppName;

        public Form_spySettings()
        {
            InitializeComponent();

            _selectedCommands = new List<ISpyCommand>();

            string thisAppPath = Path.GetDirectoryName(
                Assembly.GetEntryAssembly().Location);
            _spyAppName = "SpyApp";
            string spyAppPath = thisAppPath + "\\" + _spyAppName + ".exe";

            _procSpyApp = new Process();
            _procSpyApp.StartInfo = new ProcessStartInfo(spyAppPath);
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
           
            //запускаем сам процесс
            _procSpyApp.Start();
        }

        private void button_start_stats_Click(object sender, EventArgs e)
        {
            //тут запускаем StatsApp и передаем ему пути с отчетами
            //textBox_stats_report
            //textBox_mod_report
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
    }
}
