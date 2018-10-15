using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    class Merge
    {
        static List<int> MergeLists(List<int> Left, List<int> Right)
        {
            List<int> Merged = new List<int>();
            while ((Left.Count != 0) && (Right.Count != 0))
            {
                if (Left[0] <= Right[0])
                {
                    Merged.Add(Left[0]);
                    Left.Remove(Left[0]);
                }
                else
                {
                    Merged.Add(Right[0]);
                    Right.Remove(Right[0]);
                }
            }
            while (Left.Count != 0)
            {
                Merged.Add(Left[0]);
                Left.Remove(Left[0]);
            }
            while (Right.Count != 0)
            {
                Merged.Add(Right[0]);
                Right.Remove(Right[0]);
            }
            return Merged;
        }
        public static List<int> Sort(List<int> MyList)
        {
            if (MyList.Count <= 1)
            {
                return MyList;
            }
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();
            foreach (int x in MyList)
            {
                if (MyList.IndexOf(x) < (MyList.Count) / 2)
                {
                    Left.Add(x);
                }
                else
                {
                    Right.Add(x);
                }
            }
            Left = Sort(Left);
            Right = Sort(Right);
            return MergeLists(Left, Right);
        }
    }
}
