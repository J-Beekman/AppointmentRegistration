using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentRegistration
{
    public partial class Patient
    {
        public string resultsString => $"{Id} {Name} {address} {phoneNumber}";
        public override string ToString()
        {
            return resultsString;
        }
    }

    public partial class Doctor
    {

    }

    public partial class Nurse
    {

    }

    public partial class Appointment
    {

    }

    public partial class Schedule
    {
        public string resultsString => $"{appointmentId} {Patient.Name} {Doctor.name} {Nurse.name}";
    }
}
