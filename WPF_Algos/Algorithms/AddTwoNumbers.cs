using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Algos.Algorithms
{
    public class AddTwoNumbers
    {
        public void Run()
        {
            ListNode l1 = new ListNode { val = 2, next = new ListNode { val = 4, next = new ListNode { val = 3, next = null } } };
            ListNode l2 = new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 4, next = null } } };
            //var p = AddTwo_Numbers(l1, l2);
            var p2 = AddTwoNumbers_V2(l1, l2);
        }

        public ListNode AddTwo_Numbers(ListNode l1, ListNode l2)
        {
            ListNode sum = new();
            ListNode node = new();
            int carry = 0;

            node = sum;


            while (l1 != null || l2 != null)
            {

                if (l1 == null)
                    l1 = new();
                if (l2 == null)
                    l2 = new();

                node.val = l1.val + l2.val + carry;
                if (node.val > 9)
                {
                    carry = 1;
                    node.val = node.val % 10;
                }
                else
                {
                    carry = 0;
                }

                l1 = l1.next;
                l2 = l2.next;

                if (l1 != null || l2 != null || carry == 1)
                {
                    node.next = new ListNode();
                    node = node.next;

                }
                if (carry == 1 && l1 == null && l2 == null)
                    node.val = 1;
            }

            return sum;
        }

        public ListNode AddTwoNumbers_V2(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode curr = dummyHead;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }

            return dummyHead.next;
        }

    }
}
