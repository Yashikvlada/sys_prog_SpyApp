using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public Form_spySettings()
        {
            InitializeComponent();

            _selectedCommands = new List<ISpyCommand>();
        }

        private void button_start_spy_Click(object sender, EventArgs e)
        {
            //тут запускаем SpyApp и передаем ему _selectedCommands
        }

        private void button_start_stats_Click(object sender, EventArgs e)
        {
            //тут запускаем StatsApp и передаем ему пути с отчетами
            //textBox_stats_report
            //textBox_mod_report
        }
    }
}
