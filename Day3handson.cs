using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3Handson
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            if (i < j)
            {
                Console.WriteLine("{0} is minimum", i);
            }
            else
            {
                Console.WriteLine("{0} is maximum", j);
            }


            Console.WriteLine("----------------------");

            //program -2

            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is greater", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("{0} is greater", b);
            }
            else
            {
                Console.WriteLine("{0} is greater", c);
            }

            Console.WriteLine("----------------------");

            //program-3

            int x, y;
            Console.WriteLine("Enter a character");
            y = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a character");
            x = Convert.ToChar(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine("Characters are equal");
            }
            Console.WriteLine("----------------------");
            //program-4
            string p = String.Empty;

            Console.WriteLine("Enter a string 1 :");
            p = Console.ReadLine();

            String q = String.Empty;
            Console.WriteLine("Enter the string 2 :");

            q = Console.ReadLine();

            if (q == p)
            {
                Console.WriteLine("{0} is equal to {1}", p, q);
            }

            Console.WriteLine("----------------------");
            //program -5


            int m, n;
            Console.WriteLine("Enter a num :");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd num :");
            n = Convert.ToInt32(Console.ReadLine());

            if (m > n)
            {
                Console.WriteLine(" {0} is greatest", m);
            }
            else
            {
                Console.WriteLine("{0} is greater", n);
            }

            Console.WriteLine("----------------------");

            //program - 6

            int X;
            Console.WriteLine("Enter the year");
            X = Convert.ToInt32(Console.ReadLine());

            if ((X % 400 == 0) && (X % 100 != 0) || (X % 4 == 0))
            {
                Console.WriteLine("{0} Year is leap", X);
            }

            else
            {
                Console.WriteLine("{0} It is not a leap year", X);
            }

            Console.WriteLine("----------------------");

            // program -7 

            int math, phy, che,Z;

            Console.WriteLine("Enter math marks");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phy marks");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter che marks");
            che = Convert.ToInt32(Console.ReadLine());

            Z = math + phy + che;

            Console.WriteLine("Total marks on three subjects are :", Z);

           
            int H = Z / 3;
            Console.WriteLine("Percentage :", H);
            


            if(Z < 35)
            {
                Console.WriteLine("Student is fail with {0} percentage", Z);
            }
            else if(Z>=35 && Z<45)
            {
                Console.WriteLine("Student is in third Place");
            }
            else if(Z>=45 && Z < 60)
            {
                Console.WriteLine("Student is in second place");
            }
            else if(Z>60)
            {
                Console.WriteLine("Student is in first place");
            }

            Console.WriteLine("----------------------");

            //program - 8

            for (int n1 = 1; i <= 5; i++)
            {
                for (int n2 = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");

            //program - 9


            int hp, dell=0, sum;
            Console.WriteLine("Enter n value");
            hp = Convert.ToInt32(Console.ReadLine());
            sum = Convert.ToInt32(Console.ReadLine());
            for ( hp= 0; hp < dell; hp++)
            {
                if ((hp % 2) != 0)
                {
                    Console.Write("{0}", hp);
                    sum += hp;

                }
                Console.Write(sum);
            }

            Console.WriteLine("----------------------");

            //program - 10

            int max, rev;
            Console.WriteLine("Enter the max value");
            max = Convert.ToInt32(Console.ReadLine());
            rev = Convert.ToInt32(Console.ReadLine());

            while(max > 0)
            {
                int remainder = max % 10;
                rev = (rev * 10) + remainder;
                max = max / 10;
            }

            Console.WriteLine("{0}", rev);

            Console.WriteLine("----------------------");

            //program -11
            int ik;
            ik = Convert.ToInt32(Console.ReadLine());

            for (ik = 0; i > 100 && ik < 200; ik++)
            {
                sum += ik;
                Console.WriteLine("Numbers between 100 and 200 :", ik);
            }



            // program - 12

            int no1, total = 0;
            Console.WriteLine("Numbers between 100 and 200 which is divisible by 9:");
            for (no1 = 100; no1 <= 200; no1++)
            {
                if ((no1 % 9) == 0)
                {
                    total += no1;
                    Console.WriteLine(no1);
                }
            }
            Console.WriteLine("Sum of number between 100 and 200 divisible by 9: " + total);
            Console.WriteLine("----------------------");
         

            //program-13

            int input1;

            Console.WriteLine("Provide Input as integer :");
            input1 = Convert.ToInt32(Console.ReadLine());

            if(input1 == 0)
                Console.WriteLine("Input is Zero");
            else if((input1%2)  != 0)
                Console.WriteLine("Input is Odd value");
            else if((input1%2) == 0)
                Console.WriteLine("Input is Even value");
            else if((input1%10)==0)
                Console.WriteLine("Divisible by 10");
            else if((input1 % 10) != 0)
                Console.WriteLine("Does not divisible by 10");
            else if(input1>=100)
                    Console.WriteLine("Number is more than 100");
            Console.WriteLine("----------------------");

            //program - 14

            int num1;
            Console.WriteLine("Enter an Input");
            num1 = Convert.ToInt32(Console.ReadLine());

            switch (num1)
            {
                case 1:
                    if (num1 == 0)
                        Console.WriteLine("Input is Zero");
                    break;
                case 2:
                    if ((input1 % 2) != 0)
                        Console.WriteLine("Input is Odd value");
                    break;
                case 3:
                    if ((input1 % 2) == 0)
                        Console.WriteLine("Input is Even value");
                    break;
                case 4:
                    if ((input1 % 10) == 0)
                        Console.WriteLine("Divisible by 10");
                    break;
                case 5:
                    if ((input1 % 10) != 0)
                        Console.WriteLine("Does not divisible by 10");
                    break;
                case 6:
                    if (input1 >= 100)
                        Console.WriteLine("Number is more than 100");
                    break;  
                default:
                    break;
            }

            // program - 15

            for (int i1=0; i1<26; i1++)
            {
                for(int j1 = 25; j1 == 0; j1--)
                {
                    Console.WriteLine("i = {0} and j = {1}", i, j);
                    if(i==j && i>j)
                    {
                        break;
                    }
                    Console.WriteLine("Loop Ended");
                }
            }






            //program - 16

            int actions = 4;
            int shots = 100;
            String inp1 = Convert.ToString(Console.ReadLine());

            while(actions >= 0)
            {
                if (inp1 == "miss")
                {
                    shots -= 20;
                    Console.WriteLine("Score", shots);
                }
                if (inp1 == "hit")
                {
                    shots += 10;
                    Console.WriteLine("Score", shots);
                    actions -= 1;

                }
            }

            Console.ReadLine();



        }
    }
}
