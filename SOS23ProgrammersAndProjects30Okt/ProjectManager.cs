namespace SOS23ProgrammersAndProjects30Okt
{
    internal class ProjectManager
    {
        Dictionary<int, Project> projects = new Dictionary<int, Project>();
        public ProjectManager()
        {
            Project jim = new Project("New Train System");
            projects.Add(jim.Id, jim);
        }

        public void ProjectMenu(Dictionary<int, Programmer> programmers)
        {
            bool continuing = true;
            while (continuing == true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add project");
                Console.WriteLine("2. List projects");
                Console.WriteLine("3. Remove project");
                Console.WriteLine("4. Add programmer to project");
                Console.WriteLine("5. List programmers working on project.");
                Console.WriteLine("9. Go Back");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddProject();
                        break;
                    case "2":
                        ListProject();
                        break;
                    case "3":
                        RemoveProject();
                        break;
                    case "4":
                        AddProgrammerToProject(programmers);
                        break;
                    case "5":
                        ListProgrammersWorkingOnProject();
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

        private void ListProgrammersWorkingOnProject()
        {
            Console.WriteLine("Which project?");
            try
            {
                int projectId = int.Parse(Console.ReadLine());
                if (!projects.ContainsKey(projectId))
                {
                    Console.WriteLine("There is no such project.");
                    return;
                }
                Project project = projects[projectId];
                project.ListProgrammers();
            }
            catch(Exception e)
            {

            }
        }

        private void AddProgrammerToProject(Dictionary<int, Programmer> programmers)
        {
            Console.WriteLine("Which project? Give their id.");
            ListProject();
            try
            {
                int projectId = int.Parse(Console.ReadLine());
                if (!projects.ContainsKey(projectId))
                {
                    Console.WriteLine("There's no such project.");
                    return;
                }

                Console.WriteLine("What programmer? Give their id.");
                foreach (Programmer programmer in programmers.Values)
                {
                    programmer.PrintInfo();
                }
                int programmerId = int.Parse(Console.ReadLine());
                if (!programmers.ContainsKey(programmerId))
                {
                    Console.WriteLine("There's no such programmer.");
                    return;
                }
                
                Project project = projects[projectId];
                Programmer chosenProgrammer = programmers[programmerId];

                project.WorkOnProject(chosenProgrammer);
            }
            catch (Exception e)
            {
                Console.WriteLine("You wrote a letter instead of a number!");
            }
        }

        private void ListProject()
        {
            foreach (Project project in projects.Values)
            {
                project.PrintInfo();
            }
        }

        private void AddProject()
        {
            Console.WriteLine("What is its name?");
            string input = Console.ReadLine();
            if (input != "")
            {
                Project project = new Project(input);
                projects.Add(project.Id, project);
                Console.WriteLine("Project " + input + " successfully added.");
            }
            else
            {
                Console.WriteLine("They can't not have name.");
            }
        }

        private void RemoveProject()
        {
            ListProject();
            Console.WriteLine("Which project would you like to remove? Give their id.");
            try
            {
                int id = int.Parse(Console.ReadLine());
                if (projects.ContainsKey(id))
                {
                    Console.WriteLine("Project " + id + " has been removed.");
                    projects.Remove(id);
                }
                else
                {
                    Console.WriteLine("There is no project with that id.");
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
    }
}