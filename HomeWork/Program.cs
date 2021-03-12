using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //My vision
            Console.WriteLine(" Hello! This is your questionary.\n Please, enter your First name and Last name.");
            var name_and_lastname = Console.ReadLine();
            Console.WriteLine("\n Enter your age.");
            short age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n Enter your height.");
            short height = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n Enter your weight.");
            short weight = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine ($"\n Questionary.\n First name and Last name: {name_and_lastname}\n Age: {age}\n Height: {height};\n Weight: {weight}");
            //Variant "a".
            Console.WriteLine("\n Questionary. First name and Last name:" + " " + name_and_lastname + " Age:" + " " + age + " Height:" + " " + height + " Weight:" + " " + weight);
            //I dont see a point in varian "b" cause i did it already.
            // Variant "c"
            Console.WriteLine($"\n Questionary. First name and Last name: {name_and_lastname} Age: {age} Height: {height} Weight: {weight}");
            Console.ReadKey();
        }
    }
}
