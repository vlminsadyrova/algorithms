using System;
using System.Linq;

namespace BoubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int[] array = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            Bouble(array);
        }

        static void Bouble(int[] arr)
        {
            var result = 0;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                bool flag = false;
                for(int j = 0; j < i; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                        result += 1;
                    }
                }
                if(flag == false)
                {
                    break;
                }
            }
            Console.WriteLine(result);

            //foreach(var n in arr)
            //{
            //    result += n + " ";
            //}
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
