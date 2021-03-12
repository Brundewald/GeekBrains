using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinate x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Here is your distance: {distance:F2}");
            Console.ReadKey();
        }
    }
}
