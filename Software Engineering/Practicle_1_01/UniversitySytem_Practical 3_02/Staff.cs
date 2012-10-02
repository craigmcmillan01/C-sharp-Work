using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversitySytem_Practical_3_02
{
    public class Staff : Person
    {
        string department { get; set; }
        string nationalInsuranceNumber { get; set; }

        public Staff(){ }
        public Staff(string name, int dob, string department, string insNum)
        : base(name, dob)
        {
            this.department = department;
            this.nationalInsuranceNumber = insNum;
        }       
    }
}
