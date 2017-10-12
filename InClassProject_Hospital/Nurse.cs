using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassProject_Hospital
{
    class Nurse : Employee
    {
        protected string department;
        protected int numberOfPatients;

        public string Department { get; }
        public int NumberOfPatients { get; set; }

        public Nurse()
        {

        }

        public Nurse(string employeeName, string employeeNumber, string department, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.numberOfPatients = numberOfPatients;
        }

        public override string EmployeeInfo()
        {
            return base.EmployeeInfo() + " " + department + " " + numberOfPatients + " patients";
        }


    }
}
