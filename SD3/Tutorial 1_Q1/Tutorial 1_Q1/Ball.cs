using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1_Q1
{
    class Ball
    {
        //properties
        protected string Name;

        //Constructors
        public Ball() { }
        public Ball(String Name) { this.Name = Name; }

        //gets and sets
        public String getName() { return Name; }
        public void setName(string Name) { this.Name = Name; }

        //methods
    }
}
