using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassProject_Hospital
{
    class Receptionist
    {
        protected string department;
        protected bool onThePhone;

        public string Department { get; }
        public bool OnThePhone { get; set; }

        public Receptionist()
        {

        }

        public Receptionist(string department, bool onThePhone)
        {
            this.department = department;
            this.onThePhone = onThePhone;
        }





    }
}
