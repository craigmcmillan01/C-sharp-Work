using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1_Q5
{
   public abstract class Student
    {
       //properties
       public string Name {get; set;}
       public string MatricNum { get; set; }
       public string YearOfStudy { get; set; }


       //constructors
       public Student() { }
       public Student (string Name, string MatricNum, string YearOfStudy)
       {
           this.Name = Name;
           this.MatricNum = MatricNum;
           this.YearOfStudy = YearOfStudy;
       }

       //Methods
       public abstract void update();
    }
}
