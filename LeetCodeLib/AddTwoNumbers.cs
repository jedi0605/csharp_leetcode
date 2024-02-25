using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 2. Add Two Numbers
    /// Careful with last carry.
    /// Remember every time when node move to next. check is null or not
    /// #Leetcode 150
    /// #Stack
    /// O(n)
    /// O(n)
    public class AddTwoNumber
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dumm = new ListNode(0);
            ListNode curr = dumm;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int v1 = l1 == null ? 0 : l1.val;
                int v2 = l2 == null ? 0 : l2.val;
                int val = v1 + v2 + carry;
                carry = val / 10;
                val = val % 10;
                curr.next = new ListNode(val);

                curr = curr.next;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            if (carry == 1)
                curr.next = new ListNode(1);
            return dumm.next;
        }
    }
}