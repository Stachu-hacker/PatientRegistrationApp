using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRegistrationApp
{
    class Appointment
    {
        protected DateTime appointmentDate;
        protected string docSurname, patientSurname;

        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
        public string DocSurname { get => docSurname; set => docSurname = value; }
        public string PatientSurname { get => patientSurname; set => patientSurname = value; }

        public Appointment(DateTime appointmentDate, string patientSurname, string docSurname)
        {
            appointmentDate = AppointmentDate;
            patientSurname = PatientSurname;
            docSurname = DocSurname;
        }
    }

}
