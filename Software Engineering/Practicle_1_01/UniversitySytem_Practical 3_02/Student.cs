using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversitySytem_Practical_3_02
{
    public class Student : Person
    {
        int matriculationNumber { get; set; }
        string programmeTitle { get; set; }

        public Student() { }
        public Student(string name, int DOB, string prog, int matric) : base(name, DOB)
        {
            this.programmeTitle = prog;
            this.matriculationNumber = matric;
        }
    }
}
