using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    class Manager : Employee
    {
        public Manager(string name, DateTime birthday, string organization, DateTime hire_date) :
    base(name, birthday, organization, hire_date, 500)
        { }

        public override void DoWork()
        {
            Console.WriteLine($"Manager {Name} is lazy and drinking coffee all the day...");
        }

        public void LookingIntoTheWindow()
        {
            Console.WriteLine($"Manager {Name} is looking into the window");
        }
    }
}
