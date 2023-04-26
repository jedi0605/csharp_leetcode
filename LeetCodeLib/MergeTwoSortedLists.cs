using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public void PrintLinkedList()
        {
            ListNode current = this;
            while (current != null)
            {
                System.Diagnostics.Debug.WriteLine(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        public bool Equals(ListNode obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            ListNode objHead = obj;
            ListNode current = this;

            while (objHead != null)
            {

                if (current == null && objHead == null)
                    return true;
                else if (current != null && objHead != null)
                {
                    if (current.val != objHead.val)
                        return false;

                    objHead = objHead.next;
                    current = current.next;
                }
                else
                    return false;
            }
            return objHead == null && current == null ? true : false;
        }
    }

    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            list1.PrintLinkedList();
            list2.PrintLinkedList();

            return null;
        }
    }
}