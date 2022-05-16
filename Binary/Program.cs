using System;
using System.Collections.Generic;
using System.Linq;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int[] array1 = Console.ReadLine().Trim().Split().Select(int.Parse).Distinct().ToArray();
            int[] array2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            var firstDict = new Dictionary<int, int>();

            foreach (var val in array2)
            {
                var left = 0;
                var right = array1.Length - 1;
                while(left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (array1[mid] == val)
                    {
                        Console.WriteLine(val);
                        break;
                    }
                    if(array1[mid] < val)
                    {
                        left = mid + 1;
                    }
                    if (array1[mid] > val)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        if (left == 0 && right == 0)
                        {
                            break;
                        }
                    }
                }
                if(val > array1[left] || val < array1[right])
                {
                    var res1 = val - array1[left];
                    var res2 = array1[right] - val;
                    Console.WriteLine(res1 < res2? array1[left] : array1[right]);
                }
            }
        }
    }
}
