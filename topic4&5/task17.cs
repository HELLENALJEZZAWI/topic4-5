using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic4_5
{
    internal class task17
    {
      

class Program
    {
        static int CalculateTotalLegs(int chickens, int cows, int pigs)
        {
            // Validate input: Ensure all numbers are non-negative
            if (chickens < 0 || cows < 0 || pigs < 0)
            {
                throw new ArgumentException("Input values must be non-negative.");
            }

            // Calculate total legs
            int totalLegs = (chickens * 2) + (cows * 4) + (pigs * 4);
            return totalLegs;
        }

        static void Main()
        {
            try
            {
                Console.Write("Enter the number of chickens: ");
                int numChickens = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the number of cows: ");
                int numCows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the number of pigs: ");
                int numPigs = Convert.ToInt32(Console.ReadLine());

                int totalLegs = CalculateTotalLegs(numChickens, numCows, numPigs);
                Console.WriteLine($"Total legs among all animals: {totalLegs}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter non-negative integers.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
}
