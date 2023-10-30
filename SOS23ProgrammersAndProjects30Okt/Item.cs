using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS23ProgrammersAndProjects30Okt
{
    internal class Item
    {
        public int Id { get; set; }
        protected string name;

        public Item(int id, string name)
        {
            Id = id;
            this.name = name;
        }
    }
}
