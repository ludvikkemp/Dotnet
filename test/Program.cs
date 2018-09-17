using System;

namespace test
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode p1 = new ListNode(3);
            p1.next.val = 4;
            p1.next.next.val = 2;

            ListNode p2 = new ListNode(4);
            p1.next.val = 6;
            p1.next.next.val = 5;

            var print = addTwoNumbers(p1, p2);

            Console.WriteLine(print.val + " " + print.next.val + " " + print.next.next.val);

        }

        static public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1;
            ListNode q = l2;
            ListNode curr = dummyHead;
            int carry = 0;

            while (p != null || q != null)
            {
                int x;
                if (p != null)
                {
                    x = p.val;
                }
                else
                {
                    x = 0;
                }

                int y;
                if (q != null)
                {
                    y = q.val;
                }
                else
                {
                    y = 0;
                }

                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                if (p != null)
                {
                    p = p.next;
                }

                if (q != null)
                {
                    q = q.next;
                }

                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }
}






