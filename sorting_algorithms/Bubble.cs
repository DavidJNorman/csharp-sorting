using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    class Bubble
    {
        public static int[] Sort(int[] MyArray)
        {
            int n = MyArray.Length;
            bool Swapped = true;
            while (Swapped)
            {
                Swapped = false;
                for (int i = 0; i < (n - 1); ++i)
                {
                    if (MyArray[i] > MyArray[i + 1])
                    {
                        int temp = MyArray[i];
                        MyArray[i] = MyArray[i + 1];
                        MyArray[i + 1] = temp;
                        Swapped = true;
                    }
                }
                --n;
            }
            return MyArray;
        }
    }
}
