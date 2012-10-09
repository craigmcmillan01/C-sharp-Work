using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicSystem_01
{
    public class Appointment
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
       
        public Appointment(int day, int month, int year)
        {
           this.day = day;
           this.month = month;
           this.year = year;
        }
        
       
    }
}
