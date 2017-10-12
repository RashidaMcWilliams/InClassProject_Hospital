using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassProject_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sharon = new Employee("Sharon White", "347");
            sharon.EmployeeInfo();
            Console.WriteLine(sharon.EmployeeInfo());

            Employee john = new Employee("John Dunne", "526");
            john.EmployeeInfo();
            Console.WriteLine(john.EmployeeInfo());




        }
    }
}
