using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_08_2022HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string str1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter 2nd string");
            string str2 = Convert.ToString(Console.ReadLine());

            if (str1.Length == str2.Length)
            {
                Console.WriteLine("String lengths are same");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }

            // program - 2

            Console.WriteLine("Enter string : ");
            string str3 = Convert.ToString(Console.ReadLine());

            string i = string.Copy(str3);

            Console.WriteLine(i);

            // program-3

            string s = "under";
            int indexOfC = s.IndexOf('d');
            Console.WriteLine("Index of c");
            Console.WriteLine(indexOfC);

            // program - 4

            string newStr = "Welcome, to Mphasis, C#";
            string[] sep = { "a", "," };
            //char[] sep = { ' ' };
            int cnt = 2;
            string[] result = newStr.Split(sep, cnt, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // program - 5

            string newStr1 = "Welcome";
            string i1 = newStr1.ToUpper();
            Console.WriteLine(i1);

            //program - 6


            program6class.FirstFile();
            Console.ReadLine();




            // program -6 class file

            public static void FirstFile()
            {
                Console.WriteLine("Hello from this text file");
            }

            // program - 7

            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine("Year : " + dt.Year);
            Console.WriteLine("Year : " + dt.Month);
            Console.WriteLine("Year : " + dt.Day);
            Console.WriteLine("Year : " + dt.Hour);
            Console.WriteLine("Year : " + dt.Minute);
            Console.WriteLine("Year : " + dt.Second);
            Console.WriteLine("Year : " + dt.Millisecond);


        }
    }
}

