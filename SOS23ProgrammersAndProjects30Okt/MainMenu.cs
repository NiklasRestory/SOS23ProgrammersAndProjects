using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS23ProgrammersAndProjects30Okt
{
    internal class MainMenu
    {
        ProgrammerManager programmerManager = new ProgrammerManager();
        ProjectManager projectManager = new ProjectManager();

        public void Menu()
        {
            bool continuing = true;
            while (continuing)
            {
                Console.Clear();
                Console.WriteLine("Where would you like to go?");
                Console.WriteLine("1: (P)rogrammer Menu");
                Console.WriteLine("2: P(r)oject Menu");
                Console.WriteLine("9: (Q)uit");
                string input = Console.ReadLine();

                switch(input.ToLower())
                {
                    case "p" or "1":
                        programmerManager.ProgrammerMenu();
                        break;
                    case "r":
                    case "2":
                        projectManager.ProjectMenu(programmerManager.GetProgrammers());
                        break;
                    case "q":
                    case "9":
                        continuing = false;
                        break;
                    default:
                        Console.WriteLine("Not an option.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
