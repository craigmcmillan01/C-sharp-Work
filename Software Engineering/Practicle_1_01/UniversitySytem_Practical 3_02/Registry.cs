using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversitySytem_Practical_3_02
{
    class Registry
    {
        public List<Student> registered = new List<Student>();

        public void addStudent(Student s, University u)
        {
            registered.Add(s);
            u.addUniMember(s);
        }

        public void printRegistry()
        {
            foreach (Student s in registered)
            {
                string output = "Registered students: " + s.name;
                Console.WriteLine(output);   
            }
            Console.ReadLine();
        }
    }
}
