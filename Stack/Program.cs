using System;

namespace Stack
{
    public class Stack
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

        // Push and Pop from top
        Node top;

        static void Main(string[] args)
        {
            Console.WriteLine("Pushing 1, 2, 3 and 4 on Stack");

            var theStack = new Stack();
            theStack.push(1);
            theStack.push(2);
            theStack.push(3);
            theStack.push(4);

            Console.WriteLine("Printing Stack:");

            Node current = theStack.top;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            Console.WriteLine("Popping 2 values");
            theStack.pop();
            theStack.pop();

            Console.WriteLine("Printing Stack Again");

            Node current2 = theStack.top;
            while (current2 != null)
            {
                Console.WriteLine(current2.data);
                current2 = current2.next;
            }
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public int peek()
        {
            return top.data;
        }

        public void push(int d)
        {
            Node newNode = new Node(d);
            newNode.next = top;
            top = newNode;
        }

        public int pop()
        {
            if (top == null)
            {
                throw new System.ArgumentException("Stack is already Empty!");
            }
            int data = top.data;
            top = top.next;
            return data;
        }


    }
}
