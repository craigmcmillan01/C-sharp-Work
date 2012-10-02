using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversitySytem_Practical_3_02
{
    public class University
    {
        List<Person> universityMembers = new List<Person>();

        public University() { }

        public void addUniMember(Person p)
        {
            universityMembers.Add(p);
        }

        public void printUni()
        {
            //foreach (Student s in universityMembers)
            //{
            //    string output = "\nThese students are registered to napier university " + s.name;
            //    Console.Write(output);
            //}

            //foreach (Staff s in universityMembers)
            //{
            //    string output = "These staff are registered to napier university" + s.name;
            //    Console.Write(output);
            //}

            foreach (Person s in universityMembers)
            {
                string output = "\nThese people are registered to napier university " + s.name;
                Console.Write(output);

                if (universityMembers.Contains(s))
                {
                    Console.WriteLine("This is contained \n");
                }
            }
            Console.ReadLine();
            
        }
    }
}
