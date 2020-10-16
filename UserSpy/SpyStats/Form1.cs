using SpyAppClasses;
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
    //приложение должно получать информацию (путь отчетов) от основного приложения (SpySettings)
    public partial class Form_stats : Form
    {
        //нужен класс для записи/чтения статистики
        private SpyInfo _spyInfo;
        //private List<FileStream> _fsList = new List<FileStream>();
        //private List<StreamReader> _srList = new List<StreamReader>();
        private bool _isOpen = true;
        public Form_stats(SpyInfo info)
        {
            _spyInfo = info;

            //тестовый набор
            //_spyInfo.WhereToWriteBadProcs = "111.txt";

            InitializeComponent();  

            AddTabs();

            //Thread scanThread = new Thread(new ThreadStart(ScanFiles));
            //scanThread.Start();
            ScanFiles();
            this.FormClosed += Form_stats_FormClosed;
        }

        private void Form_stats_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isOpen = false;
        }

        private void AddTabs()
        {
            AddOneTab(_spyInfo.WhereToWriteBadProcs);
            AddOneTab(_spyInfo.WhereToWriteKeys);
            AddOneTab(_spyInfo.WhereToWriteProcs);
            AddOneTab(_spyInfo.WhereToWriteWords);
        }
        private void AddOneTab(string tabName)
        {
            if (tabName != "")
            {
                TabPage newTab = new TabPage(tabName);

                TextBox report = new TextBox();
                report.ReadOnly = true;
                report.Multiline = true;
                report.ScrollBars = ScrollBars.Both;
                report.Dock = DockStyle.Fill;

                newTab.Controls.Add(report);
                tabControl_main.TabPages.Add(newTab);
            }
        }
        private void ScanFiles()
        {
            foreach (TabPage t in tabControl_main.TabPages)
            {
                Thread newFile = new Thread(
                    new ParameterizedThreadStart(ReadFileThread));
                newFile.Start(t);
            }
        }
        private void ReadFileThread(object t)
        {
            var tabPage = t as TabPage;
            var fileName = (TextBox)tabPage.Controls[0];

            //FileStream fs = null;
            //_fsList.Add(fs);
            //StreamReader sr = null;
            //_srList.Add(sr);

            try
            {
                while (_isOpen)
                {
                    using (var fs = new FileStream(tabPage.Text, FileMode.Open,
                               FileAccess.Read, FileShare.ReadWrite))
                    {
                        using(var sr=new StreamReader(fs))
                        {
                            fileName.Text = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
