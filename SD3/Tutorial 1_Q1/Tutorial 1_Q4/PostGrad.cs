using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Tutorial_1_Q5
{
    class PostGrad : Student
    {
        //constructors
        public PostGrad() { }
        public PostGrad(string Name, string MatricNum, string YearOfStudy) : base(Name, MatricNum, YearOfStudy) { }

        //methods
        public override void update()
        {
            MessageBox.Show("This is in the post grad update");
        }
    }
}
