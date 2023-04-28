using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRegistrationApp
{
    public class Patient
    {
        private string
            name,
            surname;

        private List<Appointment>
            appointments;
        private DateTime
            dateOfBirth,
            dateOfDeath;

        public Patient(string name,string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Appointments = new List<Appointment>();
            
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime DateOfDeath { get => dateOfDeath; set => dateOfDeath = value; }
        internal List<Appointment> Appointments { get => appointments; set => appointments = value; }

        public string GetPersonalInfo()
        {
            return $"Name: {Name}\n" +
                $"Surname: {Surname}\n" +
                $"Date of birth {DateOfBirth.ToString("dd/MM/yyyy")}";
        }
        public string ShowAppointments()
        {
            foreach(Appointment appointment in Appointments)
            {
                return $"date: {appointment.AppointmentDate}\n" +
                    $"surname: {appointment.PatientSurname}\n" +
                    $"doctor: {appointment.DocSurname}";
            }
            return null;
        }
    }
}
