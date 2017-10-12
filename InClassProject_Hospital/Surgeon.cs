using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassProject_Hospital
{
    class Surgeon : Doctor
    {
        protected bool isOperating;

        public bool IsOperating { get; set; }

        public Surgeon()
        {

        }

        public Surgeon(string employeeName, string employeeNumber, string specialty, bool isOperating)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialty = specialty;
            this.isOperating = isOperating;
        }

        public override string EmployeeInfo()
        {
            return base.EmployeeInfo() + " " + specialty + " " + isOperating;
        }



    }
}
