using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[12];
            int i;
            Console.WriteLine("Input 10 elements in an array :");
            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("element - {0}",i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in array are :");
            for(i=0; i< 10; i++)
            {
                Console.Write("{0}", arr1[i]);  
            }

            //program - 2

            int[] arr = new int[10];
            Console.WriteLine("Input the number of elements to store in the array :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} number of elements in the array", a);
            for ( i = 0; i < arr.Length; i++)
            {
                Console.Write("element - {0}:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are:");
            foreach (var n1 in arr)
            {
                Console.WriteLine(n1);
            }
            Console.WriteLine("The values store into the array in reverse are:");
            Array.Reverse(arr);
            foreach (var n2 in arr)
            {
                Console.WriteLine(n2);
            }

            //program -3

            int[] a1 = new int[10];
            Console.WriteLine("Input the number of elements to store in the array :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} number of elements in the array", b);
            for (i = 0; i < a1.Length; i++)
            {
                Console.Write("element - {0}:", i);
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int s = 0;
            foreach (var sum in a1)
            {
                s += sum;
            }
            Console.WriteLine("Sum of all elements stored in the array is : " + s);

            //program -4

            Console.WriteLine("Array list of 5 elements:");
            ArrayList ar = new ArrayList(5);
            ar.Add(100);
            ar.Add("Hello");
            ar.Add(1000);
            ar.Add("hi");
            ar.Add(1222);
            foreach (var h1 in ar)
            {
                Console.WriteLine(h1);
            }
            ar.Remove(10);
            ar.Remove("Bye");
            Console.WriteLine("After removing '10' and 'Bye':");
            foreach (var h1 in ar)
            {
                Console.WriteLine(h1);
            }
            int c = ar.Count;
            Console.WriteLine("Count of remaining elements: " + c);

            // program - 5

            Console.WriteLine("Jagged Array:");
            int[][] jagged_arr = new int[4][];
            jagged_arr[0] = new int[4] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 1, 2, 3 };
            jagged_arr[2] = new int[] { 1, 2, 3, 4, 5, 6 };
            jagged_arr[3] = new int[] { 1, 2, 3 };
            for (int h2 = 0; h2 < jagged_arr.Length; h2++)
            {
                Console.WriteLine("Classroom {0}: ", h2);
                for (int jag = 0; jag < jagged_arr[h2].Length; jag++)
                {
                    Console.Write("Student " + jagged_arr[h2][jag] + " ");
                }
                Console.WriteLine();
            }

            //program -6

  
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Push(50);
            st.Push(60);
            Console.WriteLine("Before Pop:");
            foreach (var h3 in st)
            {
                Console.WriteLine(h3);
            }
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("After Pop:");
            foreach (var h4 in st)
            {
                Console.WriteLine(h4);
            }
            int d = st.Count;
            Console.WriteLine("Count is : " + d);
            Console.WriteLine("Top Most element on the Stack: " + st.Peek());
            st.Pop();
            Console.WriteLine("After Pop:");
            foreach (var h5 in st)
            {
                Console.WriteLine(h5);
            }

            //program - 7

            Console.WriteLine("Queue elements :");
            Queue que = new Queue(5);
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Enqueue(40);
            que.Enqueue(50);
            que.Dequeue();
            foreach (var h6 in que)
            {
                Console.WriteLine(h6);
            }
            Console.WriteLine("the Queue: " + que.Peek());

            // program  - 8

            Hashtable ht = new Hashtable();
            ht.Add(1, "Coffee");
            ht.Add(2, "Tea");
            ht.Add(3, "Milk");
            ht.Add(4, "Coke");
            Console.WriteLine("Hashtable elements are: ");
            foreach (DictionaryEntry h7 in ht)
            {
                Console.WriteLine(h7.Key + " " + h7.Value);
            }
            ht.Remove(4);
            Console.WriteLine("After removing :");
            foreach (DictionaryEntry h8 in ht)
            {
                Console.WriteLine(h8.Key + " " + h8.Value);
            }

            // program - 9

            int[] arr4 = new int[10];
            int n;
            int i5;
            int j;
            int tmp;


            Console.Write("\n\nSort elements of array in ascending order :\n");
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i5 = 0; i5 < n; i5++)
            {
                Console.Write("element - {0} : ", i5);
                arr4[i5] = Convert.ToInt32(Console.ReadLine());
            }

            for (i5 = 0; i5 < n; i5++)
            {
                for (j = i5 + 1; j < n; j++)
                {
                    if (arr4[j] < arr4[i])
                    {
                        tmp = arr4[i5];
                        arr4[i5] = arr4[j];
                        arr4[j] = tmp;
                    }
                }
            }
            Console.Write("Elements of array in sorted ascending order:\n");
            for (i5 = 0; i5 < n; i5++)
            {
                Console.Write("{0}  ", arr4[i5]);

            }
            for (i5 = 0; i5 < n; i5++)
            {
                for (j = i5 + 1; j < n; j++)
                {
                    if (arr4[j] > arr4[i5])
                    {
                        tmp = arr4[i];
                        arr4[i5] = arr4[j];
                        arr4[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted descending order:\n");
            //for (j = i + 1; j < n; j++)
            {
                Console.Write("{0}  ", arr4[i]);
            }
            Console.Write("\n\n");

            // program - 10


            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Apple");
            dic.Add(2, "Banana");
            dic.Add(3, "Mango");
            dic.Add(4, "Orange");
            foreach (var h9 in dic)
            {
                Console.WriteLine(h9.Key + " " + h9.Value);
            }

            //  program - 11

            SortedList<int, string> lst = new SortedList<int, string>();
            lst.Add(3, "Mango");
            lst.Add(1, "Apple");
            lst.Add(2, "Banana");
            lst.Add(4, "Orange");
            foreach (var h10 in lst)
            {
                Console.WriteLine(h10.Key + " " + h10.Value);
            }

            // program - 12

            int[] arr2 = new int[20];
            for ( i = 0; i < arr2.Length; i++)
            {
                Console.Write("element-{0}: ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = arr2[0]; int max = arr[0];
            foreach (var h11 in arr2)
            {
                if (h11 > max)
                {
                    max = h11;
                }
                if (h11 < min)
                {
                    min = h11;
                }
            }
            Console.WriteLine( max);
            Console.WriteLine(min);

            // program - 13

            int[] arr3 = { 1, 3, 5, 200, 22, 2244, 213, 111 };
            Console.WriteLine("Elements greater than 100 are:");
            foreach (var h12 in arr3)
            {
                if (h12 > 100)
                {
                    Console.WriteLine(h12);
                }
            }

            // program -14

            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");


            Console.WriteLine("---NumberNames---");
            foreach (var kvp in numberNames)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);

            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };
            Console.WriteLine("---Cities---");
            foreach (var kvp in cities)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);

            // program -15

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.Write("Number of elements in Stack: {0}\n", myStack.Count);

            while (myStack.Count > 2)
                Console.Write(myStack.Pop() + ",");

            Console.Write("Number of elements in Stack: {0}\n", myStack.Count);

        }
    }
}
