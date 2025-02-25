using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace WPF_Algos.Algorithms
{
    public class SwapNodesInPairs
    {
        //Given a linked list, swap every two adjacent nodes and return its head.
        //You must solve the problem without modifying the values in the list's nodes
        //(i.e., only nodes themselves may be changed.)
        public void Run()
        {
            ListNode head = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 3,
                        next = new ListNode()
                        { val = 4, next = null }
                    }
                }
            };
            SwapNodes_InPairs(head);
        }

        public ListNode SwapNodes_InPairs(ListNode head)
        {
            if (head == null)
                return null;

            ListNode dummyHead = head.next == null ? head : head.next;
            ListNode current = head;
            ListNode prev = null;
            bool isOdd = true;

            while (current != null)
            {
                if (isOdd)
                {
                    if (prev != null && current.next != null)
                        prev.next = current.next;

                    prev = current;
                    current = current.next;
                }
                else
                {
                    prev.next = current.next;
                    current.next = prev;
                    current = prev.next;
                }

                isOdd = !isOdd;
            }

            return dummyHead;
        }
    }
}
