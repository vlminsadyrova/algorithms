using System;
using System.Linq;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int[] arr1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            string num = Console.ReadLine();
            int num1 = Convert.ToInt32(num);
            int num2 = Jump(arr1, num1);

            if (num2 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Search(arr1, num2));
            }
        }
        static int Jump(int[] array, int num)
        {
            int b = (int)Math.Sqrt(array.Length);
            int start = 0;
            int end = b - 1;

            while (array[end] < num)
            {
                if(end == array.Length - 1)
                {
                    break;
                }
                start = Math.Min(array.Length - 1, start + b);
                end = Math.Min(array.Length - 1, end + b);
            }

            if (num > array[end])
            {
                return 0;
            }

            for (int i = start; i <= end; i++)
            {
                if (num == array[i])
                {
                    return i;
                }
            }
            return 0;
        }

        static int Search(int[] array, int num)
        {
            int result = 0;
            for (int i = num; array[num] >= array[i];)
            {
                if (array[num] == array[i])
                {
                    result += 1;
                }
                if(i < array.Length - 1)
                {
                    i++;
                }
                else
                {
                    return result;
                }
            }
            return result;
        }
    }
}
