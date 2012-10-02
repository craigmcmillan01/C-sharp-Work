using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Tutorial_1_Q5
{
    class UnderGrad : Student
    {
        //constructors
        public UnderGrad() { }
        public UnderGrad(string Name, string MatricNum, string YearOfStudy) : base(Name, MatricNum, YearOfStudy) { }

        //methods
        public override void update()
        {
            MessageBox.Show("this is the update in the student method");
        }
    }
}
