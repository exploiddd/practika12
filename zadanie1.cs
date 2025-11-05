using fafa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fafa
{
    internal class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Mult(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль!");
                return 0;
            }
            return a / b;
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
            Console.WriteLine($"15 + 6 = {Calculator.Add(15, 6)}");
            Console.WriteLine($"16 - 5 = {Calculator.Minus(16, 8)}");
            Console.WriteLine($"7 * 7 = {Calculator.Mult(7, 7)}");
            Console.WriteLine($"21 / 3 = {Calculator.Div(21, 3)}");
            Calculator.Div(10, 0);
        }
    }
}


