using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {31, 15, 10, 2, 4, 2, 14, 23, 12, 66 };

            StrategySort sort = new SelectionSort();
            Context context = new Context(sort, arr1);

            context.Sort();
            context.PrintArray();

            int[] arr2 = { 1, 5, 10, 2, 4, 12, 14, 23, 12, 66 };

            sort = new InsertionSort();
            context = new Context(sort, arr2);

            context.Sort();
            context.PrintArray();

            int[] arr3 = { 1, 8, 4, 7, 3, 7, 1, 6 };
            sort = new BubleSort();
            context = new Context(sort, arr3);
            context.Sort();
            context.PrintArray();

        }
    }
}
