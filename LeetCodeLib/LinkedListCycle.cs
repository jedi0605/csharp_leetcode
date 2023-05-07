using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    // Slow and Fast pointer
    public static class LinkedListCycle
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                // head = head.next;
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return true;
            }
            return false;
        }

    }
}