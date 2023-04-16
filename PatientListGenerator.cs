using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRegistrationApp
{
    public static class PatientListGenerator
    {
        public static Random rnd = new Random();
        public static List<Patient> patientsList;

        static PatientListGenerator()
        {
            string namesListRaw = "Zayne,Emmalee,Britany,Gladys,Josef,Dariana,Ivan,Nathanael,Sarai,Jayla,Rocky,Jade,Kerri,Kirk,Enoch,Thalia,Shane,Theodore,Justice,Cain,Wendy,Brenna,Jasmin,Raquel,Shirley,Jalon,Jacey,Blaise,Ellen,Vance,Triniti,Nicklaus,Menachem,Mackenna,Simone,Alysa,Quinten,Amanda,Carol,Ester,Damon,Elle,Jaida,Rohan,Aubrey,Theron,Mckinley,Madalynn,Luther,Jailyn,Annalisa,Dylan,Saira,Imari,Jorden,Sherry,Casey,Jamir,Micaela,Deion,Weston,Pierre,Cristofer,Yvette,Brent,Melody,Cassandra,Estrella,Aysha,Rubi,Sergio,Chaim,Keyon,Lisette,Annabel,Chiara,Quinn,Brandan,Beth,Tristan,Tyasia,Janeth,Kalista,Kai,Veronica,Carrington,Anya,Aisha,Markus,Marisa,Heriberto,Cyrus,Michael,Colin,Deante,Terry,Abigayle,Regan,Leonardo,Maleah";
            string[] namesList = namesListRaw.Split(',');

            string surnamesListRaw = "Freed,Otoole,Hedrick,Irby,Kaye,Nowak,Hussain,Sinclair,Douglas,Stock,Williams,Mohr,Durant,Hanson,Lipscomb,Victor,Lyle,Quinones,Chappell,McFadden,Carden,Cahill,Bolden,Downs,Ayala,Ogden,Radford,Gilman,Ramsey,Spear,Sherman,Clement,Upchurch,Cutler,Bustamante,Valencia,Tejada,Burrows,Brunson,Terrell,Kohn,Valerio,Pak,Benton,Boothe,Villarreal,Johnston,Weaver,Locklear,Jacob,Laws,Stacy,Wylie,Sorensen,Trinidad,Chavis,Costa,Concepcion,Cormier,Severson,Oldham,Batchelor,Brantley,Melendez,Mcghee,Lugo,Sumner,Yanez,Adams,Ames,Weber,Haley,Teague,Elizondo,Tsai,Beaty,Frias,Gallardo,Bernal,Peterman,Magana,Pyle,Winston,Mateo,Stephenson,Shell,Keyes,Hussey,Harvey,Rodrigues,Jeffries,Cuellar,Starks,Minter,Haddad,Holmes,Miller,Soto,Heredia,Zhu";
            string[] surnamesList = surnamesListRaw.Split(',');

            patientsList = new List<Patient>();
            for (int i = 0; i < 90; i++)
            {
                string name = namesList[rnd.Next(0, 90)];
                string surname = surnamesList[rnd.Next(0, 90)];
                patientsList.Add(new Patient(name: name, surname: surname));
            }
        }

        public static List<Patient> GetRandomizedPatientsList()
        {
            return patientsList;
        }
    }
}
