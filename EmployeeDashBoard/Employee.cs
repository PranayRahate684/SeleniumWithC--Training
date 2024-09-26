using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashBoard
{
    public class Employee
    {
        public int empid;
        public string empName;
        public string empPerformance;
        public double empSalary;
        public static string companyName;

        //Setting get set property for empId value validation
        public int EmpId
        {
            get
            {
                return empid;
            }

            set
            {
                if (value > 100)
                {
                    empid = value;

                }
                else
                {
                    Console.WriteLine(".....Invalid employee id. Please enter valid employee id above 100.....");
                }
            }
        }

        public string EmpPerformance
        {
            get
            {
                return empPerformance;
            }
            set
            {
                if (value.Equals("A") || value.Equals("B") || value.Equals("C"))
                {
                    empPerformance = value;
                }
                else
                {
                    Console.WriteLine("Please enter valid grade : Eg: A or B or C");

                }
            }
        }

        public void DisplayEmpDetail()
        {
            int empid = 999;
            Console.WriteLine("Emp id : " + this.empid);
            Console.WriteLine("Employee Name is : " + empName);
            Console.WriteLine("Employee Perfomance is : " + empPerformance);
            Console.WriteLine("Employee Salary is : " + empSalary);
  
            Console.WriteLine("Employee Company Name is :" + companyName);


        }
        public Employee()
        {
            Console.WriteLine("TEST");
        }
        public Employee(int num)
        {
            Console.WriteLine("Contstructor requires int");
        }

        //Allocate Bonus
        public void AllocateBonus()
        {
            if (empPerformance != null) 
            {
                if (empPerformance.Equals("A"))
                {
                    empSalary = empSalary + 1000;
                }
                else if (empPerformance.Equals("B"))
                {
                    empSalary = empSalary + 500;
                }
                else { empSalary = empSalary + 100; }
            }
        }
           
    }
}
