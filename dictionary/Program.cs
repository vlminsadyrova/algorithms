using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int[] array1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int num2 = int.Parse(Console.ReadLine());
            var firstDict = new Dictionary<int, int>();

            foreach (var val in array1)
            {
                if (firstDict.TryGetValue(val, out var _))
                {
                    firstDict[val] += 1;
                }
                else
                {
                    firstDict[val] = 1;
                }
            }

            var result = new List<int>();

            if (firstDict.TryGetValue(num2, out var count))
            {
                result.Add(count);
            }
            else
            {
                result.Add(0);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
