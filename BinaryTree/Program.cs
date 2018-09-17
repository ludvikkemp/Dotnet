using System;

namespace BinaryTree
{
    public class Node
    {
        public Node left, right;
        public int data;
        public Node(int d)
        {
            data = d;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inserting 5, 3, 8, 7, 10. 1 and 4 in BinaryTree!");
            var root = new Node(5);
            root.insert(3);
            root.insert(8);
            root.insert(7);
            root.insert(10);
            root.insert(1);
            root.insert(4);

            Console.WriteLine("Checking if 7 is in Tree:");
            if (root.contains(7))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("Checking if 9 is in Tree:");
            if (root.contains(9))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("Printing Tree InOrder:");
            root.printInOrder();

            Console.WriteLine("Printing Tree PreOrder:");
            root.printPreOrder();

            Console.WriteLine("Printing Tree PostOrder:");
            root.printPostOrder();

        }

        public void insert(int value)
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.insert(value);
                }
            }
        }

        public bool contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.contains(value);
                }
            }
        }

        public void printInOrder()
        {
            if (left != null)
            {
                left.printInOrder();
            }

            Console.WriteLine(data);

            if (right != null)
            {
                right.printInOrder();
            }
        }

        public void printPreOrder()
        {
            Console.WriteLine(data);

            if (left != null)
            {
                left.printPreOrder();
            }

            if (right != null)
            {
                right.printPreOrder();
            }
        }

        public void printPostOrder()
        {
            if (left != null)
            {
                left.printPostOrder();
            }

            if (right != null)
            {
                right.printPostOrder();
            }

            Console.WriteLine(data);
        }
    }






}
