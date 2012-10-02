using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//TODO get this repo working again. 
namespace UniversitySytem_Practical_3_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Craig", 12, "Games Dev", 10004794);
            PhdStudent ph1 = new PhdStudent("Mark", 12, "Games Dev", 10004794, "study of bannanas");
            Staff staff1 = new Staff("Scott", 14, "computing", "123456");
            acedemicStaff ac1 = new acedemicStaff("Leigh", 14, "computing", "123456", "Games");
            Registry reg = new Registry();
            Payroll payRoll = new Payroll();
            University napier = new University();

            reg.addStudent(st1, napier);
            reg.addStudent(ph1, napier);
            //reg.printRegistry();

            payRoll.addStaff(ac1, napier);
            payRoll.addStaff(staff1, napier);
            //payRoll.printPayroll();

            napier.printUni();
        }
    }
}
