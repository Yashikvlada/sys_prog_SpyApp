using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (args.Length != 0)
                Console.WriteLine(args.Length);

            Console.WriteLine("Spy is app!");
            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
        }
    }
}
