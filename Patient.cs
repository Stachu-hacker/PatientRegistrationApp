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

        private (DateTime,string,string)
            appointments;
        private DateTime
            dateOfBirth,
            dateOfDeath;

        public Patient(string name,string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public (DateTime, string, string) Appointments { get => appointments; set => appointments = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime DateOfDeath { get => dateOfDeath; set => dateOfDeath = value; }

        public string GetPersonalInfo()
        {
            return $"Name: {Name}\n" +
                $"Surname: {Surname}\n" +
                $"Date of birth {DateOfBirth.ToString("dd/MM/yyyy")}";
        }
    }
}
