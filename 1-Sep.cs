using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_1st_PS
{
    internal class Program
    {


        //PROGRAM - 1 Shell Short


        //  Algo: 1) Initilize the value of h(interval)/Decide your interval/default interval =1
        //2) Create a smaller sublist
        //3) Sort the sublist
        //4) Repeat this, till the whole list is sorted
        //static void Main(string[] args)
        //{
        //    ShellSort();
        //    Console.Read();

        //}
        //static void printAll(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }

        //}

        //static void ShellSort()
        //{
        //    int[] arr = new int[] { 35, 33, 42, 10, 14, 19, 16, 27, 44 };//9
        //    int inner, outer, valueToInsert, interval = 1, i = 0;
        //    Console.WriteLine("Before Sort the array=");
        //    printAll(arr);
        //    Console.WriteLine("----------------------------");
        //    while (interval <= ((arr.Length) / 3))
        //    {
        //        //  h=h*3+1
        //        interval = interval * 3 + 1;
        //    }
        //    while (interval > 0)
        //    {
        //        for (outer = 0; outer < arr.Length; outer++)
        //        {
        //            valueToInsert = arr[outer];
        //            inner = outer;
        //            while ((inner > interval - 1) && (arr[inner - interval] >= valueToInsert))
        //            {
        //                arr[inner] = arr[inner - interval];
        //                inner = inner - interval;
        //                Console.WriteLine("Item moved= " + arr[inner]);
        //            }
        //            arr[inner] = valueToInsert;
        //            Console.WriteLine("Item inserted at =" + arr[inner]);
        //        }
        //        interval = (interval - 1) / 3;
        //        i += 1;
        //    }
        //    Console.WriteLine("After Sort the array=");
        //    printAll(arr);

        //}




        // PROGRAM - 2 - MERGR SORT


        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 31, 41, 77, 25, 8, 32, 17, 40, 42 };
            Console.WriteLine("Before Sort :");
            printarray(arr);
            Console.WriteLine("-------");
            int end = arr.Length - 1;

            mergeSort(arr, 0, end);
            Console.WriteLine("after Sort :");
            printarray(arr);

            Console.ReadLine();
        }
        static void printarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void mergeSort(int[] arr, int beg, int end)
        {
            if (beg < end)
            {
                int mid = (beg + end) / 2;
                mergeSort(arr, beg, mid);
                mergeSort(arr, mid + 1, end);
                MergeSubsets(arr, beg, mid, end);


            }



        }

        static void MergeSubsets(int[] arr, int beg, int mid, int end)
        {
            int i, j, k;
            int n1 = mid - beg + 1;
            int n2 = end - mid;

            int[] leftArr = new int[n1];
            int[] RightArr = new int[n2];

            for (int i1 = 0; i1 < n1; i1++)
            {
                leftArr[i1] = arr[beg + i1];
                for (int j1 = 0; j1 < n2; j1++)
                {
                    RightArr[j1] = arr[mid + 1 + j1];
                }
            }
            i = 0;
            j = 0;
            k = beg;

            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= RightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = RightArr[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = RightArr[j];
                j++;
                k++;
            }

        }
    }
}






