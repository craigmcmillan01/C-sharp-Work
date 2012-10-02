using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversitySytem_Practical_3_02
{
    public class Payroll
    {
        protected List<Staff> payRoll = new List<Staff>();

        public void addStaff(Staff s, University u)
        {
            payRoll.Add(s);
            u.addUniMember(s);
        }

        public void printPayroll()
        {
            foreach (Staff s in payRoll)
            {
                string output = "Staff on payRoll: " + s.name;
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
