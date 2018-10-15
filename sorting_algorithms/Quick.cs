using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    class Quick
    {
        public static int[] Sort(int[] MyArray)
        {
            int Partition(int lo, int hi)
            {
                int pivot = MyArray[lo];
                int i = lo - 1;
                int j = hi + 1;
                while (true)
                {
                    do
                    {
                        ++i;
                    } while (MyArray[i] < pivot);
                    do
                    {
                        --j;
                    } while (MyArray[j] > pivot);
                    if (i >= j)
                        return j;
                    int temp = MyArray[i];
                    MyArray[i] = MyArray[j];
                    MyArray[j] = temp;
                }
            }

            void QuickSort(int lo, int hi)
            {
                if (lo < hi)
                {
                    int p = Partition(lo, hi);
                    QuickSort(lo, p);
                    QuickSort(p + 1, hi);
                }
            }

            QuickSort(0, MyArray.Length - 1);
            return MyArray;
        }
    }
}
