using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1_Q2
{
    class Staff : Person
    {
          //properties

        //constructors
        public Staff() { }
        public Staff(string name, string address, string age) : base(name, address, age) { }

        public override void Update()
        {
            System.Windows.MessageBox.Show("Running the update method of staff");
        }

        public override void draw()
        {
            System.Windows.MessageBox.Show("Running the draw method of staff");
        }
    }
}
