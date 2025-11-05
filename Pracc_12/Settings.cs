using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43l0v3k
{
    internal class Settings
    {
        private static readonly string configPath;

        static Settings()
        {
            configPath = "C:\\System32\\test\\config.json";
        }

        public static void ShowConfigPath()
        {
            Console.WriteLine($"Путь к файлу конфигурации: {configPath}");
        }
    }
}
