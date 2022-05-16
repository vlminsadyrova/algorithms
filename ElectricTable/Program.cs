using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectricTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            int numGroup = Convert.ToInt32(number);
            var tables = new List<TableModel>();

            for(int j = 0; j < numGroup; j++)
            {
                Console.ReadLine();
                int[] lineAndСolumn = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                var dict = new Dictionary<int, int[]>();

                for (int i = 0; i < lineAndСolumn[0]; i++)
                {
                    int[] line = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                    dict.Add(i, line);
                }

                var c = Console.ReadLine();
                int cleek = Convert.ToInt32(c);
                int[] column = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

                
                var tableModel = new TableModel(
                    Table: dict,
                    Cleek: cleek,
                    Column: column);

                tables.Add(tableModel);
            }

            Filtr(tables);
        }

        static void Filtr(List<TableModel> tables)
        {
            foreach(var table in tables)
            {
                if(table.Cleek > 0)
                {
                    for(int i = 0; i < table.Cleek; i++)
                    {

                    }
                }
            }
        }
    }
    public sealed record TableModel(
     Dictionary<int, int[]> Table,
     int Cleek,
     int[] Column
    );
}
