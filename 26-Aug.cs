using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb1
{
    internal class Assignment1_2_3_4

        static void Main(string[] args)
    {
        Students[] std = new Students[10];
        for (int i = 0; i < std.Length; i++)
        {
            std[i] = new Students();
            Console.WriteLine("Enter Detals of Student {0}: ", i);
            Console.WriteLine("Enter Student ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Department Number:");
            int dept = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter College Name:");

            std[i].AcceptData(id, name, dept);
        }

        for (int i = 0; i < std.Length; i++)
        {
            Console.WriteLine("Details of Students {0}:", i);
            std[i].DisplayDetails();

        }
        Console.ReadLine();
    }
    /*--------------------------------------------------------------*/

    static void Main(string[] args)
    {
        Students[] std = new Students[2];
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Enter Detals of Student {0}: ", i);
            Console.WriteLine("Enter Student ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Department Number:");
            int dept = Convert.ToInt32(Console.ReadLine());
            std[i].AcceptData(id, name, dept);
        }

        for (int j = 0; j < 2; j++)
        {
            Console.WriteLine("Student Details are {0}:", j);
            std[j].DisplayDetails();
        }
        Console.ReadLine();
    }

    struct Students
    {

        int Sno, Deptno;
        string Sname;
        public void AcceptData(int sno, string sname, int deptno)
        {
            Sno = sno;
            Sname = sname;
            Deptno = deptno;

        }
        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + Sno);
            Console.WriteLine("Student Name: " + Sname);
            Console.WriteLine("Student Department Number: " + Deptno);

        }



    }
    /*------------------------------------------------------------------*/
    static void Main(string[] args)
    {
        List<Products> product = new List<Products>();
        product.Add(new Products { Pid = 1, Pname = "Bat", Price = 100 });
        product.Add(new Products { Pid = 2, Pname = "Ball", Price = 120 });
        product.Add(new Products { Pid = 3, Pname = "wickets", Price = 2000 });
        Console.WriteLine("All Product Details: ");
        foreach (var item in product)
        {
            Console.WriteLine("Product ID: " + item.Pid);
            Console.WriteLine("Product Name: " + item.Pname);
            Console.WriteLine("Product Price: " + item.Price);
        }
        Console.WriteLine("-------------------");

        Console.WriteLine("After Removing Product Ball: ");
        product.Remove(new Products { Pid = 2, Pname = "Ball", Price = 120 });
        foreach (var item2 in product)
        {
            Console.WriteLine("Product ID: " + item2.Pid);
            Console.WriteLine("Product Name: " + item2.Pname);
            Console.WriteLine("Product Price: " + item2.Price);
        }

        Console.ReadLine();
    }
    /*----------------------------------------------------------------------------*/
    static void Main(string[] args)

    {
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddFirst("one");
        var nodeThree = linkedList.AddLast("three");
        linkedList.AddBefore(nodeThree, "two");
        linkedList.AddAfter(nodeThree, "four");

        Console.WriteLine("The first list is as:");
        foreach (string value in linkedList)
        {

            Console.WriteLine(value);

        }

        Console.WriteLine("The node one contain in the list:" + linkedList.Contains("one"));
        Console.WriteLine("The node six contain in the list:" + linkedList.Contains("six"));

        linkedList.Remove("three");

        linkedList.RemoveFirst();
        linkedList.RemoveLast();

        Console.WriteLine("The list is as:");
        foreach (string value in linkedList)
        {

            Console.WriteLine(value);

        }

        linkedList.Clear();
        Console.WriteLine("The list is now empty");
        foreach (string value in linkedList)
        {

            Console.WriteLine(value);

        }

    }

}