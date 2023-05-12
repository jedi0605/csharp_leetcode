using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class MiddleOfLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode anker = head;
            // count of node             
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }

            int middleNote = (count / 2) ;
            
            for (int i = 0; i < middleNote; i++)
            {
                 anker = anker.next;
            }

            return anker;
        }
    }
}