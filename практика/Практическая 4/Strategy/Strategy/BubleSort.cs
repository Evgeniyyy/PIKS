using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class BubleSort : StrategySort
    {
        public BubleSort()
        {
            Title = "Buble Sort";
        }
        public override string ToString()
        {
            return Title;
        }
        public override void Sort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }


        }

    }
}