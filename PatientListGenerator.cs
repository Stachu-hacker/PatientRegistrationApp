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

            string datesOfBirthListRaw = ("12/06/1960,21/01/2020,03/01/2009,09/10/1963,30/01/1996,16/06/1979,08/07/1990,28/08/2022,01/10/2022,28/05/1995,01/06/1985,20/04/1963,15/07/1995,04/03/1966,01/01/1970,19/09/1975,15/04/1962,28/07/1970,22/01/1961,26/08/1991,23/06/1976,10/01/2015,11/09/2025,15/10/1963,16/01/2025,16/03/1985,26/12/1990,24/03/1999,14/10/1972,03/08/2003,18/06/2000,15/05/1974,17/11/2000,12/03/2026,29/04/1966,19/03/1999,04/10/1967,10/04/1969,12/04/2004,05/06/1993,13/02/1975,23/10/2017,28/10/2019,24/01/1971,21/03/2006,30/07/2011,11/01/2017,04/11/2008,09/11/2014,28/02/2004,04/07/1967,30/09/2007,30/04/2029,24/01/1992,21/03/1969,11/12/1988,05/10/2023,14/01/1967,29/05/2024,20/12/1979,07/03/1993,23/03/1966,30/12/1972,18/09/2005,24/12/2014,03/05/2012,15/07/1975,29/12/2005,19/06/1985,10/11/2016,24/04/1984,19/03/1973,07/08/1972,24/12/2006,08/09/2028,27/07/1983,05/07/1992,01/02/2021,01/03/2028,09/03/1978,24/11/1980,15/10/1991,19/08/1977,10/07/1982,30/05/1984,30/09/2004,01/12/2003,02/04/2009,15/05/1974,12/05/2018,17/10/2024,08/09/2004,19/10/1972,15/05/2002,25/12/2001,23/06/1978,28/05/2009,03/06/2020,29/09/2023,19/03/2014");
            
            string datesOfBirthRaw = datesOfBirthListRaw.Trim();
            string [] datesOfBirthListStr = datesOfBirthListRaw.Split(',');
            DateTime[] datesOfBirthList = new DateTime [datesOfBirthListStr.Length];
            for (int i=0;i<datesOfBirthListStr.Length;i++)
            {
                datesOfBirthList[i] = DateTime.Parse(datesOfBirthListStr[i]);
            }

            patientsList = new List<Patient>();
            for (int i = 0; i < 90; i++)
            {
                string name = namesList[rnd.Next(0, 90)];
                string surname = surnamesList[rnd.Next(0, 90)];
                DateTime dateOfBirth = datesOfBirthList[rnd.Next(0, 90)];
                patientsList.Add(new Patient(name: name, surname: surname, dateOfBirth: dateOfBirth));
            }
        }

        public static List<Patient> GetRandomizedPatientsList()
        {
            return patientsList;
        }
    }
}
