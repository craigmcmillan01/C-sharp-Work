using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Observer_example
{
    public class Lecturer : Observable
    {
        //Properties
        private ArrayList myStudents = new ArrayList();
        private string news { get; set; }

        // Constructors
        public Lecturer() { }
        
        // Methods
        public void registerObservers(Student s)
        {
            this.myStudents.Add(s);
        }

        public void removeObservers(Student s)
        {
            this.myStudents.Remove(s);
        }

        public void notiffyObservers()
        {
            foreach(Student temp in this.myStudents)
            {
                temp.update(this.news);
            }
        }

        public void setNews(string news)
        {
            this.news = news;
        }
    }
}
