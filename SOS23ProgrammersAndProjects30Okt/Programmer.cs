using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS23ProgrammersAndProjects30Okt
{
    internal class Programmer : Item
    {
        private static int nextProgrammerId = 1;
        public Programmer(string name) 
            : base(nextProgrammerId, name)
        {
            nextProgrammerId++;
        }

        public string GetInfo()
        {
            return "Programmer " + Id + ", Name: " + name;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Programmer " + Id + ", Name: " + name);
        }
    }
}
