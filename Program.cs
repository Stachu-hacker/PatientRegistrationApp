using System;
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

                var menu = new Menu(new string[] { "Make an appointment", "Register a patient", "Check patient's info", "Delete an appointment","Exit" });
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
                     //case "Make an appointment":MakeAppointment();break;
                     //case "Register a patient": Register();break;
                     case "Check patient's info": PatientInfo();break;
                     //case "Delete an appointment": DeleteAppointment();break;
                     case "Exit" : running=false;break;
                 }

            }
        }
        static void PatientInfo()
        {
            Clear();
            Console.Write("Surname: ");
            string searchedSurname = ReadLine();
            List<Patient> patientsList = CreatePatients();
            bool found = false;
            foreach (var patient in patientsList)
            {
                if (patient.Surname == searchedSurname)
                {
                    WriteLine(patient.GetPersonalInfo());
                    found = true;
                };
            }
            if(!found) Write("There is no registered patient under that name");
            ReadKey();
        }
        //======================CREATING LIST OF PATIENTS==================================================
        static List<Patient> CreatePatients()
        {
            string namesListRaw = "Zayne,Emmalee,Britany,Gladys,Josef,Dariana,Ivan,Nathanael,Sarai,Jayla,Rocky,Jade,Kerri,Kirk,Enoch,Thalia,Shane,Theodore,Justice,Cain,Wendy,Brenna,Jasmin,Raquel,Shirley,Jalon,Jacey,Blaise,Ellen,Vance,Triniti,Nicklaus,Menachem,Mackenna,Simone,Alysa,Quinten,Amanda,Carol,Ester,Damon,Elle,Jaida,Rohan,Aubrey,Theron,Mckinley,Madalynn,Luther,Jailyn,Annalisa,Dylan,Saira,Imari,Jorden,Sherry,Casey,Jamir,Micaela,Deion,Weston,Pierre,Cristofer,Yvette,Brent,Melody,Cassandra,Estrella,Aysha,Rubi,Sergio,Chaim,Keyon,Lisette,Annabel,Chiara,Quinn,Brandan,Beth,Tristan,Tyasia,Janeth,Kalista,Kai,Veronica,Carrington,Anya,Aisha,Markus,Marisa,Heriberto,Cyrus,Michael,Colin,Deante,Terry,Abigayle,Regan,Leonardo,Maleah";
            string[] namesList = namesListRaw.Split(',');

            string surnamesListRaw = "Freed,Otoole,Hedrick,Irby,Kaye,Nowak,Hussain,Sinclair,Douglas,Stock,Williams,Mohr,Durant,Hanson,Lipscomb,Victor,Lyle,Quinones,Chappell,McFadden,Carden,Cahill,Bolden,Downs,Ayala,Ogden,Radford,Gilman,Ramsey,Spear,Sherman,Clement,Upchurch,Cutler,Bustamante,Valencia,Tejada,Burrows,Brunson,Terrell,Kohn,Valerio,Pak,Benton,Boothe,Villarreal,Johnston,Weaver,Locklear,Jacob,Laws,Stacy,Wylie,Sorensen,Trinidad,Chavis,Costa,Concepcion,Cormier,Severson,Oldham,Batchelor,Brantley,Melendez,Mcghee,Lugo,Sumner,Yanez,Adams,Ames,Weber,Haley,Teague,Elizondo,Tsai,Beaty,Frias,Gallardo,Bernal,Peterman,Magana,Pyle,Winston,Mateo,Stephenson,Shell,Keyes,Hussey,Harvey,Rodrigues,Jeffries,Cuellar,Starks,Minter,Haddad,Holmes,Miller,Soto,Heredia,Zhu";
            string[] surnamesList = surnamesListRaw.Split(',');

            List<Patient> patientsList = new List<Patient>();
            Random rnd = new Random();
            for(int i=0; i < 90; i++)
            {
                string name = namesList[rnd.Next(0, 90)];
                string surname = surnamesList[rnd.Next(0, 90)];
                patientsList.Add(new Patient(name: name, surname: surname) { Name = name, Surname = surname});

            }
            return patientsList;
            
        }
    }
}
