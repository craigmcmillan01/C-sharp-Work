using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows;

namespace Tutorial_1_Q5
{
    class Lecturer
    {
        //properties
        protected string Name { get; set; }
        protected string Department { get; set; }
        protected ArrayList ClassList = new ArrayList();

        //constructors
        public Lecturer() { }
        public Lecturer(string Name, string Department)
        {
            this.Name = Name;
            this.Department = Department;
        }

        //methods
        public void update() 
        {
            foreach (Student i in ClassList)
            {
                string output = Name + " teaches the following students "+this.Department+"\nName: " + i.Name + "\nMatricNum: "+i.MatricNum+"\nYearOfSudy: "+i.YearOfStudy;
                MessageBox.Show(output);
            }

            foreach (int i in ClassList)
            {
                MessageBox.Show(i.ToString());
            }
        }

        public void Teaches(Student s1)
        {
            int i = 12;
            this.ClassList.Add(s1);
            this.ClassList.Add(i);
        }
    }
}
