using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Enter the 1st number");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 2st number");
        b = Convert.ToInt32(Console.ReadLine());

        addition(a, b);
    }

    static void addition(int p, int q)
    {
        int res = p + q;
        Console.WriteLine("result of two numbers sum is :" + res);

    }



// program -2

int n1, n2;

Console.WriteLine("Enter the 1st number");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 2st number");
n2 = Convert.ToInt32(Console.ReadLine());


int res = add(n1, n2);
Console.WriteLine("Sum of Two numbers is :" + res);
        }
        static int add(int i, int j)
{
    return i + j;

}


// program -3

employee emp = new employee();

Console.WriteLine("Enter employee number :");
emp.a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Employee name :");
emp.b = Convert.ToString(Console.ReadLine());

Console.WriteLine("Enter Employee Salary :");
emp.c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Employee Dept Number :");
emp.d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Employee Details are:");
emp.DisplayInfo();
Console.ReadLine();





        }
        struct employee
{
    int _empno;
    public int a
    {
        get
        {
            return _empno;
        }
        set
        {
            _empno = value;
        }
    }

    string _ename;
    public string b
    {
        get { return _ename; }
        set { _ename = value; }
    }

    int _sal;
    public int c
    {
        get { return _sal; }
        set { _sal = value; }
    }

    int _deptno;
    public int d
    {
        get { return _deptno; }
        set { _deptno = value; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine(_empno);
        Console.WriteLine(_ename);
        Console.WriteLine(_sal);
        Console.WriteLine(_deptno);

    }

    // program -4


    Employee emp = new Employee();

    Console.WriteLine("Enter Employee number");
            emp.eno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name");
            emp.ename = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Employee salary");
            emp.esal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee department number");
            emp.edeptno = Convert.ToInt32(Console.ReadLine());

            emp.AcceptData(int eno, string ename, int esal, int edeptno);
            Console.WriteLine("Employee details are : ");
            emp.Display();
            Console.ReadLine();



        }

struct Employee
{
    int Empnum, Esal, Edept;
    string EmpName;
    public static AcceptData(int empno, string ename, int sal, int deptno)
    {
        Empnum = empno;
        EmpName = ename;
        Esal = sal;
        Edept = deptno;

    }
    public static Display()
    {
        Console.WriteLine("Employee number is :", +Empnum);
        Console.WriteLine("Employee Name is :", +EmpName);
        Console.WriteLine("Employee salary is :", +Esal);
        Console.WriteLine("Employee Dept number is :", +Edept);

    }

    // program -5

    //program - 6

    Console.WriteLine("Enter Department Name for number: ");
                string dname = Console.ReadLine();
                if (dname == "Purchase")
                {
                    int dep = (int)deptnames.Purchase;
    Console.WriteLine(dep);
                }
                else if (dname == "Sales")
{
    int dep = (int)deptnames.Sales;
    Console.WriteLine(dep);
}
else if (dname == "Training")
{
    int dep = (int)deptnames.Training;
    Console.WriteLine(dep);
}
else if (dname == "Accounts")
{
    int dep = (int)deptnames.Accounts;
    Console.WriteLine(dep);
}
else
    Console.WriteLine("not a department");
Console.ReadLine();
            }
            enum deptnames
{
    Purchase = 1,
    Sales = 2,
    Training = 3,
    Accounts = 4
}

// program - 7

try
{
    Console.WriteLine("Enter i : ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter j : ");
    int j = Convert.ToInt32(Console.ReadLine());

    int Divans = i / j;
    Console.WriteLine(Divans);

}
catch (DivideByZeroException ex)
{

    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);

}
        }

// program -8

int i, j;
Console.WriteLine("Enter 1st Number:");
i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd Number:");
j = Convert.ToInt32(Console.ReadLine())
            add(i, j);
Console.ReadLine();
        }
        public static void add(int a, int b)
{
    int i;
    try
    {
        i = a / b;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.StackTrace);
    }
    Console.ReadLine();
}
}