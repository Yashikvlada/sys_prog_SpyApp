using System;
using System.Collections.Generic;
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
                info.DeserializeFromString(args[0]);

                var props = typeof(SpyInfo).GetProperties();
                foreach(var p in props)
                {

                    Console.WriteLine(p.Name+":"+ typeof(SpyInfo).GetProperty(p.Name).GetValue(info));
                }
                Console.WriteLine("Spy is working!");
                ///тут работа spy
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
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

                Thread thr2 = new Thread(new ThreadStart(PressedKeysStats));
                thr2.Start();
            }
            private void ProcessStats()
            {

            }
            private void PressedKeysStats()
            {

            }
        }
    }
}
