using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    class Selection
    {
        public static int[] Sort(int[] MyArray) // from wikipedia
        {
            for (int i = 0; i < MyArray.Length - 1; ++i)
            {
                int jMin = i;
                for (int j = i + 1; j < MyArray.Length; ++j)
                {
                    if (MyArray[j] < MyArray[jMin])
                        jMin = j;
                }
                if (jMin != i)
                {
                    int temp = MyArray[i];
                    MyArray[i] = MyArray[jMin];
                    MyArray[jMin] = temp;
                }
            }
            return MyArray;
        }
    }
}
