using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassProject_Hospital
{
    class Employee
    {
        protected string employeeName;
        protected string employeeNumber;

        public string EmployeeName { get; }
        public string EmployeeNumber { get; }

        public Employee()
        {

        }

        public Employee(string employeeName, string employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }

        public virtual string EmployeeInfo()
        {
            return employeeName + " " + employeeNumber;
        }



    }
}
