﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRegistrationApp
{
    class Patient
    {
        private string
            name,
            surname;

        private string[]
            appointments;
        private DateTime
            dateOfBirth,
            dateOfDeath;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string[] Appointments { get => appointments; set => appointments = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime DateOfDeath { get => dateOfDeath; set => dateOfDeath = value; }
    }
}