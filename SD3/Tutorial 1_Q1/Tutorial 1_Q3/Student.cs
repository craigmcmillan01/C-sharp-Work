using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1_Q3
{
    class Student : Person , PrintDetails_Iface
    {
        //properties

        //constructors
        public Student() { }
        public Student(string name, string address, string age) : base(name, address, age) { }

        //methods
        public override void Update()
        {
            System.Windows.MessageBox.Show("Running the update method of student");
        }

        public override void draw()
        {
            System.Windows.MessageBox.Show("Running the draw method of student");
        }

        public void printDetails()
        {
            string output = "Name: " + this.name + "\nAddress: " + this.address + "\nAge: " + this.age;
            System.Windows.MessageBox.Show(output);
        }

        public void updateDetails()
        {
            this.name = "Scott";
            this.Address = "EDINBURGH!";
            this.Age = "66,dick";
        }
    }
}
