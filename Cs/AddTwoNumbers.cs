using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    public class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum = 0;
            int valueResult = 0;
            ListNode total = new ListNode();
            while (l1 != null || l2 != null || sum > 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                }
                valueResult = sum % 10;
                total.next = new ListNode(valueResult);
                sum = sum % 10;
            }
            return total.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
