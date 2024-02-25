using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{    
    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // result is a hook to keep return
            ListNode reuslt = new ListNode(0);
            // for treval all list
            ListNode current = reuslt;
            while (list1 != null && list2 != null)
            {
                if (list1 == null && list2 == null)
                    return null;
                if (list1 == null)
                    return list2;
                if (list2 == null)
                    return list1;

                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            if (list1 != null)
                current.next = list1;
            else
                current.next = list2;
            return reuslt.next;
        }
    }
}