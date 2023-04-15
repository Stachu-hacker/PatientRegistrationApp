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
           
            
            
            SetBufferSize(800, 600);
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Welcome to Patietn Registration Application");
            System.Threading.Thread.Sleep(1000);
            ResetColor();
            Clear();
            WriteLine("MENU");

            var menu = new Menu(new string[] { "Make an appointment", "Check patient's info", "Delete an appointment" });
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
            WriteLine($"Selected option: {menu.SelectedOption ?? "(noting)"}");

            ReadKey();
        }
    }
}
