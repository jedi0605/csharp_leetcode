using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeetCodeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void SpiralMatrixReviewTest()
        {
            int[][] input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            IList<int> res = SpiralMatrixReview.SpiralOrder(input);
            Assert.IsTrue(res.Count == 9);
        }
        [TestMethod]
        public void SpiralMatrixReviewTest2()
        {
            int[][] input = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
            IList<int> res = SpiralMatrixReview.SpiralOrder(input);
            Assert.IsTrue(res.Count == 12);
        }
    }
}