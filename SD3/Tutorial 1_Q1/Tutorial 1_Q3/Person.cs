using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1_Q3
{
    
   public abstract class Person
    {
       //properties
       protected string name;
       protected string address;
       protected string age;

       //constructors
       public Person() { }
       public Person(string name, string address, string age)
       {
           this.name = name;
           this.address = address;
           this.age = age;
       }

       //gets and sets
       public string Name
       {
           get{return name;}
           set{name = value;}
       }
       public string Address
       {
           get { return address; }
           set { address = value; }
       }
       public string Age
       {
           get { return age; }
           set { age = value; }
       }

       //methods
       public abstract void Update();
       public abstract void draw();
    }
}
