using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversitySytem_Practical_3_02
{
    public class PhdStudent : Student
    {
        string thesisTitle { get; set; }

        public PhdStudent() { }
        public PhdStudent(string name, int DOB, string prog, int matric, string thesis)
            : base(name, DOB, prog, matric)
        {
            this.thesisTitle = thesis;
        }
    }
}
