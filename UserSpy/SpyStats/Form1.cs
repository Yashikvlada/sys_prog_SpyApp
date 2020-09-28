using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpyStats
{
    //приложение со статистикой, нужно считывать два файла (или 1 или 0)
    //и записывать результат в поле textBox_log
    //приложение должно получать информацию (путь отчетов) от основного приложения (SpySettings)
    public partial class Form_stats : Form
    {
        //нужен класс для записи/чтения статистики
        private string _statsPath;
        private string _moderingPath;
        public Form_stats()
        {
            InitializeComponent();

            //в новом потоке (иначе окно не запустится, т к мы в конструкторе)
            Thread newThread = 
                new Thread(new ThreadStart(ScanFilesThread));
            newThread.Start();
        }

        private void ScanFilesThread()
        {
            string testPath = "testlog.txt";
            try
            {
               using(FileStream sr=new FileStream(testPath,FileMode.OpenOrCreate))
                {
                
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
