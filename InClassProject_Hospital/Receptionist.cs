using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassProject_Hospital
{
    class Receptionist : Employee
    {
        protected string department;
        protected bool onThePhone;

        public string Department { get; }
        public bool OnThePhone { get; set; }

        public Receptionist()
        {

        }

        public Receptionist(string employeeName, string employeeNumber, string department, bool onThePhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.onThePhone = onThePhone;
        }

        public override string EmployeeInfo()
        {
            string phoneStatus;
            if(onThePhone == true)
            {
                phoneStatus = " currently on the phone";
            }
            else
            {
                phoneStatus = "currently available";
            }

            return base.EmployeeInfo() + " " + department + " " + phoneStatus;
        }


        //public virtual string ReceptionistInfo()
        //{
        //    return employeeName + " " + employeeNumber + " " + department + " " + onThePhone;
        //}



    }
}
