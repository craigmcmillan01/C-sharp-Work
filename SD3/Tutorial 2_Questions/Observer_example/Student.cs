using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_example
{
    public class Student : DisplayElement, Observer
    {
        // Properties
        private string name { get; set; }
        private string updates;

        // Constructors
        public Student() { }
        public Student(string name) { this.name = name; }

        // Methods
        public void display()
        {
            string news = "News for " + this.name + "\n";
            news = news + this.updates;
            System.Windows.MessageBox.Show(news);
        }

        public void update(string theNews)
        {
            this.updates = theNews;
            display();
        }
    }
}
