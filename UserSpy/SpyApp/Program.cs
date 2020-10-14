using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
                info.LaunchedProcesses = "ProcsStasReport.txt";
                info.PressedKeys = "KeysReport.txt";
                info.BadAppsPath = "BadApps.txt";
                info.CloseBadApp = true;
                //info.ModerOn = true;
                
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
    }
}
