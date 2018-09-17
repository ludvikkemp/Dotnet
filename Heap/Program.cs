using System;

namespace Heap
{
    public class MinIntHeap
    {
        public static int capasity = 10;
        public int size = 0;
        public int[] items = new int[capasity];

        public int getLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        public int getRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        public int getParentIndex(int childIndex) { return (childIndex - 1) / 2; }

        public bool hasLeftChild(int index) { return getLeftChildIndex(index) < size; }
        public bool hasRightChild(int index) { return getRightChildIndex(index) < size; }
        public bool hasParent(int index) { return getParentIndex(index) >= 0; }

        public int leftChild(int index) { return items[getLeftChildIndex(index)]; }
        public int rightChild(int index) { return items[getRightChildIndex(index)]; }
        public int parent(int index) { return items[getParentIndex(index)]; }

        static void Main(string[] args)
        {
            Console.WriteLine("Adding 10, 15, 20, 17 and 25 to Heap!");
            var theHeap = new MinIntHeap();
            theHeap.add(10);
            theHeap.add(15);
            theHeap.add(20);
            theHeap.add(17);
            theHeap.add(25);

            Console.WriteLine("Print Heap!");
            for (int i = 0; i < theHeap.size; i++)
            {
                Console.WriteLine(theHeap.items[i]);
            }
        }

        public void swap(int indexOne, int indexTwo)
        {
            int temp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }

        public void ensureExtraCapasity()
        {
            if (size == capasity)
            {
                //Array.Copy(items, items, capasity * 2);
                Array.Resize<int>(ref items, capasity * 2);
                capasity = capasity * 2;
            }
        }

        public int peek()
        {
            if (size == 0)
            {
                throw new System.Exception("Size of Array equals 0");
            }
            return items[0];
        }
        // Extracts the minimum element and removes it from the array
        public int poll()
        {
            if (size == 0)
            {
                throw new System.Exception("Size of Array equals 0");
            }
            int item = items[0];
            items[0] = items[size - 1];
            size--;
            heapifyDown();
            return item;
        }

        public void add(int item)
        {
            ensureExtraCapasity();
            items[size] = item;
            size++;
            heapifyUp();
        }

        public void heapifyUp()
        {
            int index = size - 1;
            while (hasParent(index) && parent(index) > items[index])
            {
                swap(getParentIndex(index), index);
                index = getParentIndex(index);
            }
        }

        public void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && rightChild(index) < leftChild(index))
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if (items[index] < items[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    swap(index, smallerChildIndex);
                }
                index = smallerChildIndex;
            }
        }
    }
}
