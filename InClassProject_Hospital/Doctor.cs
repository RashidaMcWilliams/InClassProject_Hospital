﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassProject_Hospital
{
    class Doctor : Employee
    {
        protected string specialty;

        public string Specialty { get; set; }

        public Doctor()
        {

        }

        public Doctor(string employeeName, string employeeNumber, string specialty)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialty = specialty;
        }

        public override string EmployeeInfo()
        {
            return base.EmployeeInfo() + " " + specialty;
        }



    }
}
