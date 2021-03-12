using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This program will help you to calculate your body mass ratio.\nEnter your height in meters:");
            Double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight in kg.");
            double weight = Convert.ToDouble(Console.ReadLine());
            double bmr = weight / Math.Pow(height,2);
            Console.WriteLine($"For your height {height} m and weight {weight} kg the body mass ratio is equal {bmr:F4}");
            Console.ReadKey();

        }
    }
}
