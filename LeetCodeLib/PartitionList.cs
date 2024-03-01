using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 86. Partition List
    /// If curr val < x, append curr to L, > x to R
    /// in the end Ltail.next = R.next. Rtail.next = null
    /// x=3
    /// H   1   4   3   2   5   2
    /// L
    /// R
    /// #Leetcode 150
    /// #Stack
    /// O(n)
    /// O(n)
    public class PartitionList
    {
        public static ListNode Partition(ListNode head, int x)
        {
            ListNode L = new ListNode();
            ListNode R = new ListNode();
            ListNode lT = L;
            ListNode rT = R;

            while (head != null)
            {
                if (head.val < x)
                {
                    lT.next = head;
                    lT = lT.next;
                }
                else
                {
                    rT.next = head;
                    rT = rT.next;
                }
                head = head.next;
            }
            lT.next = R.next;
            rT.next = null;
            return L.next;
        }
    }
}