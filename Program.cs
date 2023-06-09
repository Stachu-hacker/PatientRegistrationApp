﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PatientRegistrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //====================WELCOME SCREEN=========================
            SetBufferSize(800, 600);
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Welcome to Patietn Registration Application");
            System.Threading.Thread.Sleep(1000);
            //=============================================================
            bool running = true;
            while (running)
            {
                ResetColor();
                Clear();
                //=============MENU==============================

                WriteLine("MENU");

                var menu = new Menu(new string[] { "Make an appointment", "Register a patient", "Check appointments", "Check patient's info", "Delete an appointment","Exit" });
                var menuDrawer = new MenuDrawer(menu);
                bool done = false;
                do
                {
                    menuDrawer.Draw(0, 2);
                    var keyInfo = ReadKey();
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: menu.MoveUp(); break;
                        case ConsoleKey.DownArrow: menu.MoveDown(); break;
                        case ConsoleKey.Enter: done = true; break;
                    }
                } while (!done);

                //WriteLine($"Selected option: {menu.SelectedOption ?? "(noting)"}");
                //=======================================================================
                //==========================MAIN LOGIC===================================
                 string selectedOption = menu.SelectedOption;
                 switch (selectedOption)
                 {
                     case "Make an appointment":MakeAppointment();break;
                     case "Register a patient": Register();break;
                     case "Check patient's info": PatientInfo();break;
                     case "Check appointments": CheckAppointment();break;
                     //case "Delete an appointment": DeleteAppointment();break;
                     case "Exit" : running=false;break;
                 }

            }
        }
        static Patient FindPatient(string searchedSurname)
        {
            List<Patient> patientsList = PatientListGenerator.GetRandomizedPatientsList();
            bool found = false;
            foreach (var patient in patientsList)
            {
                if (patient.Surname == searchedSurname)
                {
                    found = true;
                    return patient;
                    
                }                
            }
            return null; ;
        }
        static void PatientInfo()
        {
            Clear();
            Console.Write("Surname: ");
            string searchedSurname = ReadLine();
            List<Patient> patientsList = PatientListGenerator.GetRandomizedPatientsList();
            Patient patient = FindPatient(searchedSurname);
            if (patient != null)
            {
                WriteLine(patient.GetPersonalInfo() + "\n");
            }
            else Write("There is no registered patient under that name");
            ReadKey();
        }
        static void Register()
        {
            Clear();
            Write("Name: ");
            string name = ReadLine();
            Write("\nSurname: ");
            string surname = ReadLine();
            Write("\nDate of Birth: ");
            DateTime dateOfBirth = DateTime.Parse(ReadLine());
            List<Patient> patientsList = PatientListGenerator.GetRandomizedPatientsList();
            patientsList.Add(new Patient(name: name, surname: surname, dateOfBirth: dateOfBirth));
            Write("\nPatient registered correctly");
            ReadKey();
        }
        static void MakeAppointment()
        {
            Write("Date of the appointment: ");
            DateTime dateOfAppointment = DateTime.Parse(ReadLine());
            Write("\nPatient's Surname: ");
            string surname = ReadLine();
            Write("\nDoctor's Surname: ");
            string docSurname = ReadLine();
            Patient patient = FindPatient(surname);
            patient.Appointments.Add(new Appointment(dateOfAppointment, surname, docSurname));
            Write("Appointment created correctly");
            ReadKey();
            
        }
        static void CheckAppointment()
        {
            Write("Surname: ");
            string searchedSurname = ReadLine();
            Patient patient = FindPatient(searchedSurname);
            Write($"{patient.ShowAppointments()}");
            ReadKey();
        }
       
    }
}