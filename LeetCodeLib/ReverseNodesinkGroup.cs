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
    public class ReverseNodesInKGroup
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode dumm = new ListNode(0, head);
            ListNode groupPre = dumm;

            while (true)
            {
                ListNode kth = getKNode(groupPre, k);
                if (kth == null) break; // 

                ListNode groupNext = kth.next;

                ListNode curr = groupPre.next;
                ListNode pre = kth.next; // connect to next Kgroup
                // revers k list
                while (curr != groupNext)
                {
                    ListNode tmp = curr.next;
                    curr.next = pre;
                    pre = curr;
                    curr = tmp;
                }
                // link to org list
                ListNode tmpPre = groupPre.next;
                groupPre.next = kth;
                groupPre = tmpPre;
            }
            return dumm.next;
        }

        private static ListNode getKNode(ListNode head, int k)
        {
            // ** && 
            while (head != null && k > 0)
            {
                head = head.next;
                k--;
            }
            return head;
        }
    }
}