using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic4_5
{
    internal class task21
    {
      

class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false; // Not prime if less than or equal to 1

            if (number == 2)
                return true; // 2 is always a prime number

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; i++)
            {
                if (number % i == 0)
                    return false; // Not prime if divisible by any i
            }

            return true; // Return true if it is prime
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(inputNumber))
                Console.WriteLine("It is a prime number.");
            else
                Console.WriteLine("It is not a prime number.");
        }
    }

}
}
