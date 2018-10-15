using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array to be randomly generated:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Unsorted = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                Unsorted[i] = rnd.Next(1000);
            }
            PrintArray(Unsorted);
            Console.WriteLine("Which sorting algorithm would you like?");
            Console.WriteLine("1 - BubbleSort");
            Console.WriteLine("2 - InsertionSort");
            Console.WriteLine("3 - SelectionSort");
            Console.WriteLine("4 - MergeSort");
            Console.WriteLine("5 - QuickSort");
            Console.WriteLine("6 - ShellSort");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PrintArray(Bubble.Sort(Unsorted));
                    break;
                case 2:
                    PrintArray(Insertion.Sort(Unsorted));
                    break;
                case 3:
                    PrintArray(Selection.Sort(Unsorted));
                    break;
                case 4:
                    List<int> UnsortedList = new List<int>();
                    UnsortedList = Unsorted.ToList<int>();
                    PrintList(Merge.Sort(UnsortedList));
                    break;
                case 5:
                    PrintArray(Quick.Sort(Unsorted));
                    break;
                case 6:
                    PrintArray(Shell.Sort(Unsorted));
                    break;
                default:
                    throw new ArgumentException("Invalid input");
            }
            
            Console.ReadLine();
        }

        static void PrintArray(int[] MyArray) // this function is not my work
        {
            Console.WriteLine("[{0}]", string.Join(", ", MyArray));
        }

        static void PrintList(List<int> MyList)
        {
            Console.WriteLine("[{0}]", string.Join(", ", MyList));
        }
    }
}
