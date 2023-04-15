using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRegistrationApp
{
        
    //logic for selecting option
    public class Menu
    {
        public Menu(IEnumerable<string> items)
        {
            Items = items.ToArray();
        }
        public IReadOnlyList<string> Items { get; }
        public int SelectedIndex { get; private set; } = -1; //nothing selected
        public string SelectedOption => SelectedIndex != -1 ? Items[SelectedIndex] : null;
        public void MoveUp() => SelectedIndex = Math.Max(SelectedIndex - 1, 0);
        public void MoveDown() => SelectedIndex = Math.Min(SelectedIndex + 1, Items.Count -1);
    }

    //logic for drawing menu
    public class MenuDrawer
    {
        readonly Menu menu;
        public MenuDrawer(Menu menu) 
        {
            this.menu = menu;
        }
        public void Draw(int x, int y)
        {
            for (int i = 0; i < menu.Items.Count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                var color = menu.SelectedIndex == i ? ConsoleColor.DarkGreen : ConsoleColor.Gray;
                Console.ForegroundColor = color;
                Console.WriteLine(menu.Items[i]);
            }
        }
    }
}   
