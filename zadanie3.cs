using fafa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fafa
{
    public class ObjectCounter
    {
        private static int count = 0;

        public ObjectCounter()
        {
            count++;
        }

        public static void PrintObjectCount()
        {
            Console.WriteLine($"Количество созданных объектов: {count}");
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
            ObjectCounter.PrintObjectCount();

            var obj1 = new ObjectCounter();
            var obj2 = new ObjectCounter();
            ObjectCounter.PrintObjectCount();

            var obj3 = new ObjectCounter();
            ObjectCounter.PrintObjectCount();
        }
    }
}