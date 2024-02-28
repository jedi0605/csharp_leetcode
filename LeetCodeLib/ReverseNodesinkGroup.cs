using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 25. Reverse Nodes in k-Group
    /// create a dummy infront of head.
    /// 1.locate kth node. groupPre, groupNext
    /// 2.revers groupPre.next to kth node
    /// 3.link groupPre <-> resers <-> group Next
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
                ListNode kth = getKth(groupPre, k);
                if (kth == null) break;
                ListNode groupNext = kth.next;
                ListNode pre = groupNext;
                ListNode curr = groupPre.next;

                // reverse
                ListNode tmp = null;
                while (curr != groupNext)
                {
                    tmp = curr.next;
                    curr.next = pre;
                    pre = curr;
                    curr = tmp;
                }

                // Link reverse List to groupPre, groupNext
                tmp = groupPre.next;
                groupPre.next = kth;
                groupPre = tmp;

            }

            return dumm.next;
        }

        private static ListNode getKth(ListNode head, int k)
        {
            while (head != null && k > 0)
            {
                head = head.next;
                k--;
            }
            return head;
        }
    }
}