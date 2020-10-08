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
            Console.WriteLine("Spy is app!");
            try
            {
                SpyInfo info = new SpyInfo();
                info.DeserializeFromString(args[0]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
        }
    }
}
