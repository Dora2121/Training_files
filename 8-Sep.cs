using DeptLibrarary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    public class Elist
    {
        int emp_id;
        string Emp_Name;
        int Emp_Salary;
        string Emp_Department;
        int departno;

        static void Main(string[] args)
        {


            List<Elist> Elists = new List<Elist>()
    {
        new Elist{emp_id = 401, Emp_Name = "Rajat", Emp_Salary = 50000,departno=10},
        new Elist{emp_id = 402, Emp_Name = "Ram", Emp_Salary = 65000,departno=10},
        new Elist{emp_id = 403, Emp_Name = "Krishna", Emp_Salary = 45000,departno=20},
        new Elist{emp_id = 404, Emp_Name = "Sonial", Emp_Salary = 20000, departno = 20},
        new Elist{emp_id = 405, Emp_Name = "Mickey", Emp_Salary = 70000, departno = 30},
        new Elist{emp_id = 406, Emp_Name = "Kunti", Emp_Salary = 50000, departno = 30},
    };
            bool result;


            result = Elists.All(Elist => Elist.emp_id > 401 && Elist.emp_id < 410);

            // Display result

            if (result)
            {
                Console.Write("Employee are limited");
            }
            else
            {
                Console.Write("Morethan or 10 in an Employee List");
            }
        }
    }

}
//--------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeptLibrarary
{
    public class Employee            //class employee, with employee id, empname, deptno, sal,mgr as properties.
    {
        private int _empId;

        public int EmployeeID
        {
            get { return _empId; }
            set { _empId = value; }
        }
        private string _empname;

        public string EmployeeName
        {
            get { return _empname; }
            set { _empname = value; }
        }
        private int _deptno;

        public int DepartNo
        {
            get { return _deptno; }
            set { _deptno = value; }
        }

        private int _sal;

        public int Salary
        {
            get { return _sal; }
            set { _sal = value; }
        }

        private string _mgr;

        public string Managers
        {
            get { return _mgr; }
            set { _mgr = value; }
        }





    }
}
//-----------------------------------------------------------------*--------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeptLibrarary
{
    public class Dept  //dept class, with deptno,dname and location
    {
        private int _deptno;

        public int DeptNO
        {
            get { return _deptno; }
            set { _deptno = value; }
        }

        private string _deptname;

        public string DeptName
        {
            get { return _deptname; }
            set { _deptname = value; }
        }

        private string _location;

        public string Addreses
        {
            get { return _location; }
            set { _location = value; }
        }



    }
}
//*-----------------------------------------------------MAIN-------------------------------------------
using DeptLibrarary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dept d = new Dept();
            d.DeptNO = 10;
            d.DeptName = "CSE";
            d.Addreses = "AP";
            Console.WriteLine("Department No:" + d.DeptNO);
            Console.WriteLine("Department Name:" + d.DeptName);
            Console.WriteLine("Department Location:" + d.Addreses);

            Console.WriteLine("-----------------------------");

            Employee emp = new Employee();
            emp.EmployeeID = 1;
            emp.EmployeeName = "Dora";
            emp.DepartNo = 10;
            emp.Salary = 10000;
            emp.Managers = "Shrini";
            Console.WriteLine("Employee Id:" + emp.EmployeeID);
            Console.WriteLine("Employee Name:" + emp.EmployeeName);
            Console.WriteLine("Employee Department:" + emp.DepartNo);
            Console.WriteLine("Employee Salary:" + emp.Salary);
            Console.WriteLine("Manager :" + emp.Managers);





        }
    }
}
