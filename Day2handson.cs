using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Handson
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // program - 1

            int n1 = 5;
            int n2 = 6;
            Console.WriteLine("Input the First Number :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second Nimber :");
            n2 = Convert.ToInt32(Console.ReadLine());
            int k = n1;
            n1 = n2;
            n2 = k;
            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number :");
            Console.WriteLine(n1);
            Console.WriteLine("Second Number :");
            Console.WriteLine(n2);



            //program - 2

            int num1, num2, num3, res;

            Console.WriteLine("Enter the first number to muliply");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number to muliply");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number to muliply");
            num3 = Convert.ToInt32(Console.ReadLine());

            res = num1 * num2 * num3;
            Console.WriteLine("{0} x {1} x {2} = {3}",num1, num2 , num3, res);


            //program - 3

            int i = 0, j = 0, l = 0, userchoice;
            char ch = '+';
            Console.WriteLine("Menu \n 1.Add \n 2.Subtract \n 3.Exit");
            userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice != 3)
            {
                Console.WriteLine("Enter value for i");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for j");
                j = Convert.ToInt32(Console.ReadLine());
            }

            switch (userchoice)
            {
                case 1:
                    ch = '+';
                    l = i + j;
                    break;
                case 2:
                    ch = '-';
                    l = i - j;
                    break;
                case 3:
                    Environment.Exit(1);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
            Console.WriteLine("The answer of {0} {1} {2}={3}", i, ch, j, l);

            


            // program -4

            int s, t, u, v, avg;
            Console.WriteLine("Enter value for s");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for t");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for u");
            u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for v");
            v = Convert.ToInt32(Console.ReadLine());
            avg = (s + t + u + v) / 4;
            Console.WriteLine(avg);

            //Program - 5

            int x, y, z, s1, s2;
            Console.WriteLine("Enter value for x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for z");
            z = Convert.ToInt32(Console.ReadLine());

            s1=(x+y)*z;
            s2 = x * y + y * z;
            Console.WriteLine("Result of specified numbers {0} , {1}, and {2}, (x + y)*z is {3} and x*y + y*z is {4}",x, y, z, s1, s2);


            //program - 6


            int age;
            Console.WriteLine("Enter your age :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than {0}.",age);


            //program - 7

            int no1;
            Console.WriteLine("Enter a number :");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" {0} {0} {0} {0}", no1);
            Console.WriteLine(" {0}{0}{0}{0}", no1); 
            Console.WriteLine(" {0} {0} {0} {0}", no1);
            Console.WriteLine(" {0}{0}{0}{0}", no1);


            // program - 8

            int np;
            Console.WriteLine("Enter a number :");
            np = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", np);
            for(int p = 1; p < 4; p++)
            {
                Console.WriteLine("{0} {0} ", np);

            }
            Console.WriteLine("{0}{0}{0}", np);


            // program - 9

            int c, h;

            Console.WriteLine("Enter the value ");
            c = Convert.ToInt32(Console.ReadLine());

            double f = c * (1.8) + 32;
            h = c + 273;


            Console.WriteLine("Value converted to celsius to kevin is :");
            Console.WriteLine(h);
            Console.WriteLine("Value converted to celsius to Fahrenheit is :");
            Console.WriteLine(f);


            Console.ReadLine();


            Console.WriteLine("-------------------");


            // program - 10


            int pos, neg;

            Console.WriteLine("Enter two numbers : ");
            pos = Convert.ToInt32(Console.ReadLine());
            neg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((pos > 0 && neg < 0) || (pos < 0 && neg > 0));

            // program - 11

            int p1, p2;

            Console.WriteLine("Enter two numbers : ");
            p1 = Convert.ToInt32(Console.ReadLine());
            p2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine((p1 > 0 && p2 > 0));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception caught : {0}", e);
            }


            //program - 12


            Console.WriteLine("Enter the stirng");
            String str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("True");
            }
            Console.WriteLine("False");



            // program - 13

            int mtr, km;

            Console.WriteLine("Enter in meteres :");
            mtr = Convert.ToInt32(Console.ReadLine());
            km = mtr / 1000;

            Console.WriteLine("Enter in kilometeres :");
            km = Convert.ToInt32(Console.ReadLine());            
            mtr = km * 1000; 

            Console.WriteLine(mtr);
            Console.WriteLine(km);

            // program - 14

            int cl, fh;

            Console.WriteLine("Enter the value ");
            cl = Convert.ToInt32(Console.ReadLine());

            fh = cl * (9 / 5) + 32;

            Console.WriteLine("Value converted to celsius to Fahrenheit is :");
            Console.WriteLine(fh);

            // program - 15

            int dollar;

            Console.WriteLine("Enter the dollar ammount");
            dollar = Convert.ToInt32(Console.ReadLine());

            double rupees = dollar + 80.05;

            Console.WriteLine("The value of {0} dollars in rupees is : {1}", dollar, rupees);

            // program - 16
            string UserId, Password;

            Console.WriteLine("Enter the First Name :");
            UserId = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Enter the Last Name : ");
            Password = Convert.ToString(Console.ReadLine());

            if ((UserId != null) && (Password != null))
            {
                Console.WriteLine("Welcome to my app");

            }


            Console.ReadLine();



























        }

    }
}
