using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 61. Rotate List
    /// 1. Find tail, length
    /// 2. Find new tail, means k+1
    /// 3. Point head to newTail.next, new tail.next = null    
    /// #Leetcode 150
    /// #Stack
    /// O(n)
    /// O(n)
    public class RotateList
    {
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;
            int length = 1;
            ListNode tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
                length++;
            }
            k = k % length;
            if (k == 0)
                return head;
            // 1    2   3   4   5    if k =2
            //          N
            // 5-2-1 = 2
            ListNode newTail = head;
            for (int i = 0; i < length - k - 1; i++)
            {
                newTail = newTail.next;
            }
            tail.next = head;
            head = newTail.next;
            newTail.next = null;
            return head;
        }
    }
}