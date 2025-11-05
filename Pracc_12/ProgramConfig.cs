using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43l0v3k
{
    internal class ProgramConfig
    {
        public const string Version = "1.0.0";
        public const string DeveloperName = "Владик, Тарасик, Никитка";

        public static void ShowInfo()
        {
            Console.WriteLine("======= Информация о программе =======");
            Console.WriteLine($"Версия: {Version}");
            Console.WriteLine($"Разработчик: {DeveloperName}");
            Console.WriteLine("======================================");
        }
    }
}
