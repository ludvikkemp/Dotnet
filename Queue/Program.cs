using System;

namespace Queue
{
    public class Queue
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
            }
        }
        // Remove data here
        Node head;
        // Add data here
        Node tail;

        static void Main(string[] args)
        {
            Console.WriteLine("Adding 1, 2, 3 and 4 to Queue");
            var theQueue = new Queue();
            theQueue.add(1);
            theQueue.add(2);
            theQueue.add(3);
            theQueue.add(4);

            Console.WriteLine("Printing Queue");

            Node current = theQueue.head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            Console.WriteLine("Removing Two Elements from Queue");

            theQueue.remove();
            theQueue.remove();

            Node current2 = theQueue.head;
            while (current2 != null)
            {
                Console.WriteLine(current2.data);
                current2 = current2.next;
            }
        }


        public bool isEmpty()
        {
            return head == null;
        }

        public int peek()
        {
            return head.data;
        }

        public void add(int d)
        {
            Node node = new Node(d);
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;
            if (head == null)
            {
                head = node;
            }
        }

        public int remove()
        {
            int data = head.data;
            head = head.next;
            if (isEmpty())
            {
                tail = null;
            }
            return data;
        }

    }
}
