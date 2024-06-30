using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace topic4_5
{
    internal class Program
    {
        //task5
        //public class MyClass
        //{
        //    public void DisplayMessage()
        //    {
        //        Console.WriteLine("MyClass class has initialized!");
        //    }
        //}
        //task9
        //public class Greeting
        //{
        //    public void DisplayMessage(string name)
        //    {
        //        Console.WriteLine($"Hello All, I am {name}");
        //    }

        //task10
        //public static long CalculateFactorial(int n)
        //{
        //    if (n < 0)
        //        throw new ArgumentException("Factorial is not defined for negative numbers.");

        //    long result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
    }
    //task17
    class Program1
    {
        static int CalculateAgeInDays(int ageInYears)
        {
            // Assuming an average of 365.25 days per year
            return ageInYears * 365;
        }
        static void Main(string[] args)
        {
            // task1
            //int[] ARR = { 1, 7 , 9 , 45 };
            //String[] arr2 = { "Str", "alex", "moh" };
            //string[] arr3 = { "the", "fox", "over", "lazy", "dog " };

            //task2
            //  What the index of "Banana","Tomato" ?
            // String[ ]  fruits = { "Tomato", "Banana", "Watermelon" };
            //Console.WriteLine($"Index of 'Banana':{fruits[0]} ");
            //Console.WriteLine($"Index of 'Tomato':{fruits[1]}");
            //task3
            //string[] favoriteFood = new string[5] { "Pizza", "Sushi", "Burgers", "Tacos", "Ice Cream" };
            //string[] favoriteSport = new string[3] { "Football", "Basketball", "Tennis" };
            //string[] favoriteMovie = new string[4] { "Inception", "The Matrix", "Pulp Fiction", "Interstellar" };
            //Console.WriteLine("Favorite Foods:");
            //foreach (string food in favoriteFood)
            //{
            //    Console.WriteLine(food);
            //}

            //Console.WriteLine("\nFavorite Sports:");
            //foreach (string sport in favoriteSport)
            //{
            //    Console.WriteLine(sport);
            //}
            //Console.WriteLine("\nFavorite Movies:");
            //foreach (string movie in favoriteMovie)
            //{
            //    Console.WriteLine(movie);
            //}
            //task4
            //    Console.Write("Input three numbers separated by comma: ");
            //    string input = Console.ReadLine();

            //    // Split the input by commas
            //    string[] numbers = input.Split(',');

            //    // Convert strings to integers and calculate the sum
            //    int sum = 0;
            //    foreach (string num in numbers)
            //    {
            //        if (int.TryParse(num, out int parsedNum))
            //        {
            //            sum += parsedNum;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter valid numbers separated by commas.");
            //            return;
            //        }
            //    }

            //    Console.WriteLine($"The sum of three numbers: {sum}.");
            //}
            //task5
            //int n = 10; // Change this value to display more or fewer terms

            //int sum = 0;
            //Console.Write("The odd numbers are: ");
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"\nThe Sum of odd Numbers is: {sum}.");
            //task6
            //Console.WriteLine("Enter the number of rows:");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{
            //    // Print spaces
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            //task7
            //int n = 4; // Number of rows
            //int number = 1;

            //for (int i = 1; i <= n; i++)
            //{

            //    for (int j = i; j < n; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(number + " ");
            //        number++;
            //    }
            //    Console.WriteLine();
            //}
            //task11
            //    int[] array = { 11, -2, 4, 35, 0, 8, -9 };

            //    // Sort the array in ascending order
            //    Array.Sort(array);

            //    // Print the sorted array
            //    Console.Write("Sorted array: { ");
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write(array[i]);
            //        if (i < array.Length - 1)
            //            Console.Write(", ");
            //    }
            //    Console.WriteLine(" }");
            //}
            //task12
            //DateTime date1 = new DateTime(1981, 11, 03);
            //DateTime date2 = new DateTime(2013, 09, 04);

            //// Calculate the difference
            //TimeSpan difference = date2 - date1;

            //// Extract years, months, and days
            //int years = difference.Days / 365;
            //int remainingDays = difference.Days % 365;
            //int months = remainingDays / 30;
            //int days = remainingDays % 30;

            //Console.WriteLine($"Difference: {years} years, {months} months, {days} days.");
            //task13
            //string dateString = "12-08-2004";

            //// Parse the string using the specified format
            //DateTime convertedDate = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);

            //// Print the converted date
            //Console.WriteLine($"Converted Date: {convertedDate:yyyy-MM-dd}");
            //task14
            double[] numbers = new double[10];
            double sum = 0;

            // Input the 10 numbers
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter Number-{i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }

            // Calculate average
            double average = sum / 10;

            // Display results
            Console.WriteLine($"The sum of 10 numbers is: {sum}");
            Console.WriteLine($"The average is: {average:F6}");
            //task15
            int i, ctr;

            Console.WriteLine("\nDisplay the cube of the numbers up to a given integer:");
            Console.WriteLine("------------------------------------------------------\n");

            Console.Write("Input the number of terms: ");
            ctr = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= ctr; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Number is: {i} and cube of {i} is: {cube}");
            }
            //task16
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            var filteredYears = years.Where(year => year > 1950);

            Console.WriteLine("Numbers greater than 1950:");
            foreach (var year in filteredYears)
            {
                Console.WriteLine(year);
            }
            //task17
            Console.Write("Enter your age in years: ");
            int ageInYears = Convert.ToInt32(Console.ReadLine());

            int ageInDays = CalculateAgeInDays(ageInYears);

            Console.WriteLine($"Your age in days is approximately: {ageInDays}");
        }

    }
}
        
    
    


