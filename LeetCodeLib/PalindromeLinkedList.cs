using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class PalindromeLinkedList
    {
        /// <summary>
        /// Fast slow skill
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool IsPalindromeQuickSlow(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            // Go to half way.
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            slow = _ReverseLinkedList(slow);
            fast = head;
            while (slow != null)
            {
                if (slow.val != fast.val)
                    return false;
                slow = slow.next;
                fast = fast.next;
            }
            return true;
        }

        public static ListNode _ReverseLinkedList(ListNode head)
        {
            ListNode pre = null;
            ListNode next = head.next;
            bool firstFlag = true;
            while (next != null)
            {
                pre = head;
                head = next;
                next = head.next;
                head.next = pre;

                if (firstFlag)
                {
                    pre.next = null;
                    firstFlag = false;
                }

            }
            return head;
        }

        public static bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            ListNode _pointHead = head;
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            while (_pointHead != null)
            {
                if (_pointHead.val != stack.Pop())
                    return false;
                _pointHead = _pointHead.next;
            }

            return true;
        }
    }
}