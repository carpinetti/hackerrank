using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Arrays
{
    public class TwoDArrayDS
    {
        public static int hourglassSum(int[][] arr)
        {
            // Instanciate all hourglasses
            var hourGlasses = new List<List<int>>();

            for (int i = 1; i < arr.Length - 1; i++)
            {
                var hLine = arr[i - 1];
                var bLine = arr[i + 1];

                for (int a = 1; a < arr[i].Length - 1; a++)
                {
                    var hg = new List<int>(7);
                    hg.Add(arr[i][a]);
                    hg.AddRange(new int[] { hLine[a - 1], hLine[a], hLine[a + 1] });
                    hg.AddRange(new int[] { bLine[a - 1], bLine[a], bLine[a + 1] });
                    hourGlasses.Add(hg);
                }
            }

            // return the one with max value;
            return hourGlasses.Max(x => x.Sum());
        }

        public static int hourglassSum2(int[][] arr)
        {
            int maxValue = int.MinValue;

            for (int row = 1; row < arr.Length - 1; row++)
            {
                for (int col = 1; col < arr[row].Length - 1; col++)
                {
                    int hLine = arr[row - 1].Skip(col - 1).Take(3).Sum();
                    int bLine = arr[row + 1].Skip(col - 1).Take(3).Sum();
                    int hourglassSum = arr[row][col] + hLine + bLine;
                    maxValue = Math.Max(maxValue, hourglassSum);
                }
            }

            return maxValue;
        }
    }
}
