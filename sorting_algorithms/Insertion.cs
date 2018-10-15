using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    class Insertion
    {
        public static int[] Sort(int[] MyArray)
        {
            for (int i = 1; i < MyArray.Length; ++i)
            {
                int j = i;
                while ((j > 0) && (MyArray[j - 1] > MyArray[j]))
                {
                    int temp = MyArray[j - 1];
                    MyArray[j - 1] = MyArray[j];
                    MyArray[j] = temp;
                    --j;
                }
            }
            return MyArray;
        }
    }
}
