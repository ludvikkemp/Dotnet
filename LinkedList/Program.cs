using System;

namespace LinkedList
{
    public class LinkedList
    {
        public class Node
        {
            public Node next;
            public int data;
            public Node(int d)
            {
                data = d;
            }
        }
        Node head;
        static void Main(string[] args)
        {
            var theList = new LinkedList();
            theList.append(1);
            theList.append(2);
            theList.append(3);

            Console.WriteLine("Printing Original Linked List");

            Node current = theList.head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            Console.WriteLine("Deleting value 2");
            theList.deleteWithValue(2);

            Console.WriteLine("Print Linked List Again");

            Node current2 = theList.head;
            while (current2 != null)
            {
                Console.WriteLine(current2.data);
                current2 = current2.next;
            }
        }
        public void append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
        }

        public void prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }

        public void deleteWithValue(int value)
        {
            if (head == null)
            {
                return;
            }
            if (head.data == value)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == value)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }
    }
}
