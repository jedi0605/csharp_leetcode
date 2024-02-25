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

        public static ListNode ArrayToListNode(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;

            ListNode head = new ListNode(arr[0]);
            ListNode current = head;

            for (int i = 1; i < arr.Length; i++)
            {
                current.next = new ListNode(arr[i]);
                current = current.next;
            }
            return head;
        }
    }
    
}