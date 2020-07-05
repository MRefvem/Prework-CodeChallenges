using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayMaxResult());
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
    }
}
