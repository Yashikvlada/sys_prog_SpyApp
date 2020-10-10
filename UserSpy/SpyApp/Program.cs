using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SpyAppClasses;

namespace SpyApp
{
    class Program
    {
        //нужно получить от главного приложения (SpySettings) информацию (что сканировать, куда писать лог)
        //приложение должно работать в фоновом режиме
        //нужно как-то его отключать из главного приложения (SpySettings)
        //всю информацию нужно писать в лог
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
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
        }
    }
}
