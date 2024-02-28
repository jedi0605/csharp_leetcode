using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 19. Remove Nth Node From End of List
    /// Lpoint Rpoint, k=2 so target is 4
    /// Two pointer approch
    /// 1   2   3   4   5 
    /// L       R   
    /// When R move to Null, L in target
    /// 1   2   3   4   5 
    ///             L       R 
    /// Add dumm node in front of List, when R reach to target
    /// L.next = L.next.next  
    /// D   1   2   3   4   5 
    ///             L           R   
    /// 3->5
    /// #Leetcode 150
    /// #Stack
    /// O(n)
    /// O(n)
    public class RemoveNthNodeFromEndofList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dumm = new ListNode(0, head);
            ListNode l = dumm;
            ListNode r = dumm;
            for (int i = 0; i < n + 1; i++)            
                r = r.next;
            
            while (r!=null)
            {
                l = l.next;
                r = r.next;
            }
            l.next = l.next.next;
            return dumm.next;
        }
    }
}