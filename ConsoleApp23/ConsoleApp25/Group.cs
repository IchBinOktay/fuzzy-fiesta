using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public class Group
    {
        public string Name { get; set; }
        public Group(string name)
        {
            Name = name;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name}");
        }
    }
}
