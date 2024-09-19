using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashBoard
{
    public class EmployeeRunner
    {
        static void Mainc(String[] args)
        {

            Employee.companyName = "TR";
            Employee emp = new Employee();
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee(102);


            emp.EmpId = 10;
            emp.empName = "Pranay";
            emp.EmpPerformance = "A";
            emp.empSalary = 102;
            Employee.companyName = "TR \n";

            emp1.EmpId = -111;
            emp1.empName = "Sanay";
            emp1.EmpPerformance = "B";
            emp1.empSalary = 103;
            Employee.companyName = "TR \n";

            emp3.EmpId = 122;

            Console.WriteLine("...........Salary After Allocating Bonus...........");
            emp.AllocateBonus();
            emp1.AllocateBonus();
            
            emp.DisplayEmpDetail();


          //  Printing the properties in Employee Runner Class for Employee class
          //Properties allow user to manage access (to give only read or write access or both)
            Console.WriteLine(emp.EmpId);

            Console.WriteLine(emp.EmpPerformance);
            emp3.DisplayEmpDetail();
        }
    }
}
