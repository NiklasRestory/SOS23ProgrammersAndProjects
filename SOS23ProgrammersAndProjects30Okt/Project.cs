using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS23ProgrammersAndProjects30Okt
{
    internal class Project : Item
    {
        private static int nextProjectId = 1;
        List<Programmer> programmers = new List<Programmer>();
        public Project(string name) 
            : base(nextProjectId, name)
        {
            nextProjectId++;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Project " + Id + ", Name: " + name);
        }

        public void ListProgrammers()
        {
            foreach(Programmer programmer in programmers)
            {
                Console.WriteLine(programmer.GetInfo() + " is working on " + name);
            }
        }

        public void WorkOnProject(Programmer programmer)
        {
            programmers.Add(programmer);
        }
    }
}