using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    class Shell
    {
        public static int[] Sort(int[] MyArray) // from Wikipedia
        {
            int[] Gaps = new int[8] {701, 301, 132, 57, 23, 10, 4, 1};
            foreach (int gap in Gaps)
            {
                for (int i = gap; i < MyArray.Length; ++i)
                {
                    int temp = MyArray[i];
                    int j;
                    for (j = i; (j >= gap) && (MyArray[j - gap] > temp); j -= gap)
                    {
                        MyArray[j] = MyArray[j - gap];
                    }
                    MyArray[j] = temp;
                }
            }
            return MyArray;
        }
    }
}
