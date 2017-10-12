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

            Receptionist sharifa = new Receptionist("Sharifa Johnson", "724", "Reception", true);
            sharifa.EmployeeInfo();
            Console.WriteLine(sharifa.EmployeeInfo());

            Receptionist wally = new Receptionist("Wei Lung Tan", "846", "Reception", false);
            wally.EmployeeInfo();
            Console.WriteLine(wally.EmployeeInfo());

            Nurse odele = new Nurse("Odelle Washington", "227", "Nurse", 31);
            odele.EmployeeInfo();
            Console.WriteLine(odele.EmployeeInfo());

            Nurse beckett = new Nurse("Beckett Hampton III", "451", "Nurse", 29);
            beckett.EmployeeInfo();
            Console.WriteLine(beckett.EmployeeInfo());

            Doctor maggie = new Doctor("Maggie Morales", "907", "Pediatrics");
            maggie.EmployeeInfo();
            Console.WriteLine(maggie.EmployeeInfo());

            Doctor ben = new Doctor("Ben Johnson", "118", "Geriatrics");
            ben.EmployeeInfo();
            Console.WriteLine(ben.EmployeeInfo());

            Surgeon kwame = new Surgeon("Kwame Wallace", "684", "Neurological", true);
            kwame.EmployeeInfo();
            Console.WriteLine(kwame.EmployeeInfo());

            Surgeon stephanie = new Surgeon("Stephanie de la Guera", "593", "Orthopedic", false);
            stephanie.EmployeeInfo();
            Console.WriteLine(stephanie.EmployeeInfo());




        }
    }
}
