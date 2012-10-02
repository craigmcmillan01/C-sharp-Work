using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1_Q2
{
    class Student : Person
    {
        //properties

        //constructors
        public Student() { }
        public Student(string name, string address, string age) : base(name, address, age) { }

        //methods
        public override void Update()
        {
            System.Windows.MessageBox.Show("Running the update method of student");
            string output = "Name: " + this.name + "\nAddress: " + this.address + "\nAge: " + this.age;
            System.Windows.MessageBox.Show(output);
        }

        public void UpdateDetails()
        {
            System.Windows.MessageBox.Show("Updating student details");
            this.name = "Scott";
            this.Address = "EDINBURGH!";
            this.Age = "66,dick";
            string output = "Name: " + this.name + "\nAddress: " + this.address + "\nAge: " + this.age;
            System.Windows.MessageBox.Show(output);
        }

        public override void draw()
        {
            System.Windows.MessageBox.Show("Running the draw method of student");
        }
    }
}
