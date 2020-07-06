using System;
using System.Runtime.CompilerServices;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayMaxResult());
            Console.WriteLine(LeapYearCalculator());
            Console.WriteLine(PerfectSequence(new[] { 2, 2, 0 }));
            //Console.WriteLine(SumOfRows());
        }

        private static int ArrayMaxResult()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Choose five numbers between 1-10");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine("Select one of the numbers in your array");
            int choice = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (choice == numbers[i])
                {
                    counter += numbers[i];
                }
            }
            return counter;
        }

        private static string LeapYearCalculator()
        {
            Console.WriteLine("Choose a year to see if it is a leap year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4  == 0)
            {   
                if (year % 100 == 0 && year % 400 == 0)
                {
                    string result = $"{year} was a leap year";
                    return result;
                } else if (year % 100 == 0)
                {
                    string result = $"{year} was not a leap year";
                    return result;
                } else
                {
                    string result = $"{year} was a leap year";
                    return result;
                }
            }
            else
            {
                string result = $"{year} was not a leap year";
                return result;
            }
        }

        private static string PerfectSequence(int[] myArray)
        {
            int sum = 0;
            int product = 1;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = myArray[i] + sum;
                product = myArray[i] * product;
            }
            if (sum == product)
            {
                return "The array is a perfect sequence";
            } 
            else
            {
                return "The array is not a perfect sequence";
            }
        }
        //private static void SumOfRows(int[,] arr)
        //{
        //    foreach (int row in arr)
        //    int sum = 0;
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length; j++)
        //            {
        //                sum = sum + arr[i, j];
        //            }
        //            Console.WriteLine($"Sum of the row {i} = {sum}");
        //        }
        //    }
        //}
    }
}
