using System;

namespace BinarySearchRecursive
{
    class Program
    {
        public static bool binarySerachRecursive(int[] array, int x, int left, int right)
        {
            if (left > right)
            {
                return false;
            }

            int mid = left + ((right - left) / 2);

            if (array[mid] == x)
            {
                return true;
            }
            else if (array[mid] > x)
            {
                return binarySerachRecursive(array, x, left, mid - 1);
            }
            else
            {
                return binarySerachRecursive(array, x, mid + 1, right);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
