using System;

namespace bubbleSort
{
    class Program
    {
        public static void bubblesort(int[] array)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                int lastUnsorted = array.Length - 1;
                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swap(array, i, i + 1);
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }
        }

        public static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
