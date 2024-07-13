using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public class GroupList<T> where T : Group

    {
        private T[] groups;
        public T[] Groups { get => groups; }
        public GroupList()
        {
            groups = new T[0];
        }

        public void GetAll()
        {
            foreach (var group in groups)
            {
                group.GetDetails();
            }

        }

        public void AddGroup(T group)
        {
            foreach (var exist in groups)
            {
                if (exist.Name == group.Name)
                {
                    Console.WriteLine("group already exists");
                    return;
                }

            }
            Array.Resize(ref groups, groups.Length + 1);
            groups[groups.Length - 1] = group;


        }

    }
}
