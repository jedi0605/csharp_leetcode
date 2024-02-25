using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 21. Merge Two Sorted Lists    
    /// #Leetcode 150
    /// #Stack
    /// O(n)
    /// O(n)
    public static class MergeTwoSortedLists2
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dumm = new ListNode();
            var curr = dumm;
            while (list1 != null && list2 != null)
            {
                if (list1.val > list2.val)
                {
                    curr.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                curr = curr.next;
            }

            /// append last of l1 or l2
            if (list1 != null)
                curr.next = list1;
            else
                curr.next = list2;
            return dumm.next;            
        }
    }
}