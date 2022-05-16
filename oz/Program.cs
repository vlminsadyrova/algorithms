using System;
using System.Collections.Generic;
using System.Linq;

namespace oz
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            int numGroup = Convert.ToInt32(number);
            var dict = new Dictionary<int, itemModel>();

            for (int i = 0; i < numGroup; i++)
            {
                var quantity = Console.ReadLine();
                var quantityItems = Convert.ToInt32(quantity);
                int[] array = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

                var item = new itemModel(
                        quantity: quantityItems,
                        sale: array
                        );

                dict.Add(i, item);
            }
            Calculator(dict);
        }

        static void Calculator(Dictionary<int, itemModel> dict)
        {
            foreach (var item in dict.Values)
            {
                var dict2 = new Dictionary<int, int>();
                foreach (var val in item.sale)
                {
                    if (dict2.TryGetValue(val, out var _))
                    {
                        dict2[val] += 1;
                    }
                    else
                    {
                        dict2[val] = 1;
                    }
                }
                int result = 0;
                foreach(var val in dict2)
                {
                    int balance;
                    var present = Math.DivRem(val.Value, 3, out balance);
                    result += (val.Value - present) * val.Key;
                }
                Console.WriteLine(result);
            }
        }
    }
    public sealed record itemModel(
         int quantity,
         int[] sale
        );
}
