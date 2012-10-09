using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicSystem_01
{
    public abstract class MedicalStaff
    {
        // Properties
        protected virtual string firstName { get; set; }
        protected string secondName { get; set; }
        protected int staffNumber { get; set; }
        List<Appointment> appointments = new List<Appointment>();

        // Constructors
        public MedicalStaff() { }
        public MedicalStaff(string firstName, string secondName, int id)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.staffNumber = id;
        }

        //methods
        public void addAppointment(Appointment a)
        {
          this.appointments.Add(a);
        }
    }
}
