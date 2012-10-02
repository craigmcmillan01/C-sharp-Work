using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1_Q3
{
   public class Staff : Person , PrintDetails_Iface
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
       
        public void printDetails()
        {
            throw new NotImplementedException();
        }

        public void updateDetails()
        {
            throw new NotImplementedException();
        }
    }
}

