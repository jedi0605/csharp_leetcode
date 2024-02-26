using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 92. Reverse Linked List II
    /// create a dummy infront of head.
    /// 1.locate left pointer
    /// 2.localte right pointer and revers
    /// 3.connect revers list to origin list
    /// #Leetcode 150
    /// #Stack
    /// O(n)
    /// O(n)
    public class ReverseLinkedListII
    {
        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode dumm = new ListNode(0, head);
            ListNode preL = dumm;
            ListNode l = head;
            //          Null
            //           |
            // 0 -> 1 -> 2 -> 3 -> 4 -> 5
            //      pL            pre   l   tmp
            // if left = 2
            for (int i = 1; i < left; i++)
            {
                preL = l;
                l = l.next;
            }

            ListNode pre = null;
            // if left=2 right =5
            for (int i = 0; i < right - left + 1; i++)
            {
                ListNode tmp = l.next;
                // break direction
                l.next = pre;
                // pre and l move foward.
                pre = l;
                l = tmp;
            }

            // reconnect reversed list
            preL.next.next = l;
            preL.next = pre;
            return dumm.next;
        }
    }
}