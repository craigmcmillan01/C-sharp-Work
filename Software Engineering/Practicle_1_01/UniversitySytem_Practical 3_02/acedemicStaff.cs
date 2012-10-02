using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversitySytem_Practical_3_02
{
    public class acedemicStaff : Staff
    {
        string faculty { get; set; }

        public acedemicStaff() { }
        public acedemicStaff(string name, int dob, string department, string insNum, string faculty)
            : base(name, dob, department, insNum)
        {
            this.faculty = faculty;
        }
    }
}
