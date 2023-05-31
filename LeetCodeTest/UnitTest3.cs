using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeetCodeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest
{
    [TestClass]
    public class UnitTest3
    {
        public static bool CompareArrays(int[][] array1, int[][] array2)
        {
            try
            {
                if (array1.Length != array2.Length)
                    return false;

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i].Length != array2[i].Length)
                        return false;

                    if (!array1[i].SequenceEqual(array2[i]))
                        return false;
                }
                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[][] input = { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int[] { 12, 16 } };
            int[] newArray = { 4, 8 };
            int[][] ans = InsertInterval.Insert(input, newArray);
            int[][] assert = { new int[] { 1, 2 }, new int[] { 3, 10 }, new int[] { 12, 16 } };
            Assert.IsTrue(CompareArrays(ans, assert));
        }
    }
}