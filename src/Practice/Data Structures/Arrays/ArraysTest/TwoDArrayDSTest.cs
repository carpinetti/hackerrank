using Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArraysTest
{
    [TestClass]
    public class TwoDArrayDSTest
    {
        [TestMethod]
        public void SampleTestCase0()
        {
            int[][] arr = new int[6][];
            string[] input = new string[] { "1 1 1 0 0 0", "0 1 0 0 0 0","1 1 1 0 0 0","0 0 2 4 4 0","0 0 0 2 0 0","0 0 1 2 4 0" };

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(input[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = TwoDArrayDS.hourglassSum2(arr);
            Assert.AreEqual(19, result);
        }

    }
}
