using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class MergeSortedArray
    {
        public void MergeBF(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < nums2.Length; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }

        /// <summary>
        /// use three pointers
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param> <summary>
        /// 
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int last = m + n - 1;
            int p1 = m - 1;
            int p2 = n - 1;
            while (p2 >= 0)
            {
                if (p1>=0 && nums1[p1] > nums2[p2])
                {
                    nums1[last] = nums1[p1];
                    last--;
                    p1--;
                }
                else
                {
                    nums1[last] = nums2[p2];
                    last--;
                    p2--;
                }
            }
        }
    }
}