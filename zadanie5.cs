using fafa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fafa
{
    public class Settings
    {
        private static readonly string configPath;
        static Settings()
        {
            configPath = @"C:\SteamLibrary\steamapps\common\dota 2 beta";
        }

        public static void PrintPath()
        {
            Console.WriteLine($"Путь к файлу конфигурации: {configPath}");
        }
    }
}


using fafa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace fafa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.PrintPath();
        }
    }
}