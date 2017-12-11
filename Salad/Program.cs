using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Program
    {
        static void Main()
        {
            string l = "==========================================================";

            Salad.Models.Salad salad = new Salad.Models.Salad();
            salad.ReadingFile("input.txt");

            // List of vegetables in the salad.
            Console.WriteLine("Initial data");
            Console.Write(salad);
            Console.WriteLine(l);

            Console.WriteLine("СaloriesInSalad: " + salad.СountsСalories());
            Console.WriteLine(l);

            // Calorie sorting.
            salad._Salad.Sort();
            Console.WriteLine("After сalorie sorting");
            Console.Write(salad);
            Console.WriteLine(l);

            // Records the composition of the salad and calories in a file.
            salad.WriteToFiles("output.txt");

            // Displays on the screen vegetables from the entered calorie limit.
            double lowerLimit;
            Console.Write("Enter lower calorie limit -->");
            lowerLimit = Convert.ToDouble(Console.ReadLine());
            double upperLimit;
            Console.Write("Enter upper calorie limit -->");
            upperLimit = Convert.ToDouble(Console.ReadLine());
            foreach (var element in salad._Salad)
            {
                if (element.Caloricity >= lowerLimit && element.Caloricity <= upperLimit)
                {
                    Console.WriteLine(element.ToString());
                }
            }
            Console.WriteLine(l);

            Console.ReadKey();
        }
    }
}
