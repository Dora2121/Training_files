using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bussinesslogic;
using data_access;
namespace helper
{
    public class Employee_Helper
    {
        Employee_DAL dal = null;
        public Employee_Helper()
        {
            dal = new Employee_DAL();
        }


        public bool AddEmployee(Employee_BAL employee)
        {
            return dal.InsertEmployee(employee);

        }
        public bool AddEmployees(Employee_BAL employee)
        {
            return dal.InsertEmployees(employee);

        }
        public bool EditEmployee(Employee_BAL employee)
        {
            return dal.UpdateEmployee(employee);
        }
        public int Count()
        {
            return dal.EmployeeCount();
        }
        public Employee_BAL searchEmployee(int empid)
        {
            return dal.FindEmployee(empid);
        }
        public List<Employee_BAL> dispEmployeeList()
        {
            return dal.EmployeeList();
        }
        public bool removebook(int employee_id)
        {
            return dal.DeleteEmployee(employee_id);
        }
    }
}
