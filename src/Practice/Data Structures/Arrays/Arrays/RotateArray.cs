using System;
using System.Linq;

namespace Arrays
{
    public class RotateArray
    {
        public void Rotate(int[] arr, int rotations)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            Console.WriteLine(string.Join(" ", a.Skip(d).Concat(a.Take(d))));
        }

    }
}
