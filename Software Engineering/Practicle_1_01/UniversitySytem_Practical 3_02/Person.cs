using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversitySytem_Practical_3_02
{
    public class Person
    {
        int dateOfBirth{ get; set; }
        public string name { get; set; }

        public Person() { }
        public Person(string name, int DOB)
        {
            this.name = name;
            this.dateOfBirth = DOB;
        }
    }
}
