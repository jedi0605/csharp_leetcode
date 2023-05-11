using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ReverseLinkedList
    {

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) // edge case.
                return null;
            ListNode pre = null;
            ListNode next = head.next;

            while (next != null)
            {
                if (pre == null) // First run. pre-> to null. otherwice will create a point loop.
                {
                    pre = head;
                    pre.next = null;
                }
                else
                    pre = head;
                head = next;
                next = next.next;

                head.next = pre;
            }
            return head;
        }
    }
}