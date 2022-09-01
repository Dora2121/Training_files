using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Day2
{
    class BubbleSortDemo
    {

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 41, 3, 12, 57, 13, 69, 23, 56 };
            bubbleSort(arr);
            Console.Read();
        }
        static void bubbleSort(int[] arr)
        {

            int temp;
            for (int i = 0; i < (arr.Length) - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("------------Sorted--------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }

    }
}
/*--------------------------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Day2
{
    class SelectionSortDemo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 41, 3, 12, 57, 13, 69, 23, 56 };
            SelectionSort(arr);
            Console.Read();

        }
        static void SelectionSort(int[] arr)
        {
            int MinIndex, i, j;
            int len = arr.Length - 1;
            for (i = 0; i < len; i++)
            {
                MinIndex = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[MinIndex])
                    {
                        MinIndex = j;
                    }
                }
                if (MinIndex != i)
                {
                    int temp = arr[MinIndex];
                    arr[MinIndex] = arr[i];
                    arr[i] = temp;
                }
            }

            Console.WriteLine("------------Sorted--------");
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }

        }
    }
}
/*----------------------------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Day2
{
    class InsertionSortDemo
    {

        static void Insert(int[] arr)
        {

            int i, j, temp;
            int n = arr.Length;
            for (i = 0; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && temp <= arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }

        static void PrintSortedArray(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 31, 25, 8, 32, 17 };
            Insert(arr);
            PrintSortedArray(arr);
            Console.Read();
        }
    }
}