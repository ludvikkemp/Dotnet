using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Fibonacci numbers:");
            var input = Console.ReadLine();
            var size = Int32.Parse(input);
            int[] arr = new int[size];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.WriteLine(fibonacci(i));
            }
        }

        static int fibonacci(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(x - 1) + fibonacci(x - 2);
            }
        }
    }
}
