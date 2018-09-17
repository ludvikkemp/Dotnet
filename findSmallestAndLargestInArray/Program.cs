using System;
using System.Collections.Generic;

namespace findSmallestAndLargestInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Smallest And Largest Element in an Array");
            int[] arr = new int[5] { 5, -200, 100, 5056, -9 };
            largestAndSmallest(arr);
        }

        public static void largestAndSmallest(int[] numbers)
        {
            int largest = Int32.MinValue;
            int smallest = Int32.MaxValue;

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
                else if (number < smallest)
                {
                    smallest = number;
                }
            }

            foreach (int number in numbers)
            {
                Console.Write(number.ToString() + ", "); ;
            }
            Console.WriteLine("Smallest is: " + smallest);
            Console.WriteLine("Largest is: " + largest);
        }
    }
}
