using fafa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fafa
{
    internal class ProgramConfig
    {
        static void Main(string[] args)
        {
            Print();
        }
        public const string version = "1.12.2";
        public const string name = "Уткин Ростислав";
        public static void Print()
        {
            Console.WriteLine($"Версия: {version}");
            Console.WriteLine($"Имя разработчика: {name}");
        }
    }
}



