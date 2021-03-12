using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variant a
            var a = 1;
            var b = 3;
            var c = 0;
            Console.WriteLine($"{a}, {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"{a}, {b}");
       
            //variant b
            a = 1;
            b = 3;
            Console.WriteLine($"{a}, {b}");
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine($"{a}, {b}");
            Console.ReadKey();

        }
    }
}
