using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SpyAppClasses;

namespace SpyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SpyInfo info = new SpyInfo();
                //info.DeserializeFromString(args[0]);

                //тестовый набор
                info.StatsOn = true;
                info.ProcessesStats = "ProcsStasReport.txt";
                //

                var props = typeof(SpyInfo).GetProperties();
                foreach(var p in props)
                {

                    Console.WriteLine(p.Name+":"+ typeof(SpyInfo).GetProperty(p.Name).GetValue(info));
                }
                Console.WriteLine("Spy is working!");

                ///тут работа spy
                SpyApp spyApp = new SpyApp(info);
                spyApp.On();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine("Press any key to close...");
            //Console.ReadLine();
        }
        class SpyApp
        {
            private SpyInfo _spyInfo;
            public SpyApp(SpyInfo spyInfo)
            {
                _spyInfo = spyInfo;
            }
            /// <summary>
            /// Запускаем Spy с учетом SpyInfo
            /// </summary>
            public void On()
            {

                Thread thr1 = new Thread(new ThreadStart(ProcessStats));
                thr1.Start();

                //Thread thr2 = new Thread(new ThreadStart(PressedKeysStats));
                //thr2.Start();
            }
            private void ProcessStats()
            {
                try
                {
                    //запускаем поток с правами администратора
                    Process.EnterDebugMode();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message + ". " +
                        "Приложение запущено без прав администратора " +
                        "(системные процессы отслежены не будут!)");
                }

                var currProcsList = 
                    Process.GetProcesses()
                    .ToList();
                
                while (true)
                {
                    var updProcsList = 
                        Process.GetProcesses()
                        .ToList();

                    var addedPrcs = 
                        ComputeAddedProcs(currProcsList, updProcsList);

                    if (addedPrcs.Count > 0)
                        LogAddedProcs(addedPrcs);

                    currProcsList = updProcsList;
                }
            }
            private List<Process> ComputeAddedProcs(List<Process> oldPrcs, List<Process> newPrcs)
            {
                List<Process> addedProcs = new List<Process>();

                foreach(var np in newPrcs)
                {
                    if (oldPrcs.Any(op => op.Id == np.Id) == false)
                        addedProcs.Add(np);
                }

                return addedProcs;
            }
            private void LogAddedProcs(List<Process> prcs)
            {
                string info = string.Empty;

                try
                {
                    foreach (var p in prcs)
                    {
                        info += $"{p.StartTime} | id = {p.Id} | {p.ProcessName}\n";
                    }
                }
                catch(Exception e)
                {
                    //для системных процессов нельзя получить StartTime (не хватает прав)
                    Console.WriteLine(e.Message);
                }
                WriteToFile(_spyInfo.ProcessesStats, info);
            }
            private void WriteToFile(string path, string info)
            {
                using(StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.Write(info);
                }
            }
            private void PressedKeysStats()
            {

            }
        }
    }
}
