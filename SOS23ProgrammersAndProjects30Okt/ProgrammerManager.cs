using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS23ProgrammersAndProjects30Okt
{
    internal class ProgrammerManager
    {
        Dictionary<int, Programmer> programmers = new Dictionary<int, Programmer>();
        public ProgrammerManager() 
        {
            Programmer jim = new Programmer("Jim");
            programmers.Add(jim.Id, jim);
        }

        public void ProgrammerMenu()
        {
            bool continuing = true;
            while (continuing == true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add programmer");
                Console.WriteLine("2. List programmers");
                Console.WriteLine("3. Remove Programmer");
                Console.WriteLine("9. Go Back");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddProgrammer();
                        break;
                    case "2":
                        ListProgrammers();
                        break;
                    case "3":
                        RemoveProgrammer();
                        break;
                    case "9":
                        continuing = false;
                        break;
                    default:
                        Console.WriteLine("That's not an option");
                        break;
                }
                Console.ReadKey();
            }
        }

        private void ListProgrammers()
        {
            foreach(Programmer programmer in programmers.Values)
            {
                programmer.PrintInfo();
            }
        }

        private void AddProgrammer()
        {
            Console.WriteLine("What's their name?");
            string input = Console.ReadLine();
            if (input != "")
            {
                Programmer programmer = new Programmer(input);
                programmers.Add(programmer.Id, programmer);
                Console.WriteLine("Programmer " + input + " successfully added.");
            }
            else
            {
                Console.WriteLine("They can't not have name.");
            }
        }

        private void RemoveProgrammer()
        {
            ListProgrammers();
            Console.WriteLine("Which programmer would you like to remove? Give their id.");
            try {  
                int id = int.Parse(Console.ReadLine());
                if (programmers.ContainsKey(id))
                {
                    Console.WriteLine("Programmer " + id + " has been removed.");
                    programmers.Remove(id);
                }
                else
                {
                    Console.WriteLine("There is no programmer with that id.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please write numbers.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number too big.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something else went wrong. How.");
                Console.WriteLine(ex);
            }
        }

        public Dictionary<int, Programmer> GetProgrammers()
        {
            return programmers;
        }
    }
}
