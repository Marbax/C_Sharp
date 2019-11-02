using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    public class Worker : Employee
    {
        public Worker(string name, DateTime birthday, string organization, DateTime hire_date) :
            base(name, birthday, organization, hire_date, 1000)
        { }

        public sealed override void DoWork() // дальше нельзя переопределять
        {
            Console.WriteLine($"Worker {Name} is working hard!");
        }

        public void ExtraWork()
        {
            Console.WriteLine($"Worker {Name} is working more hardly");
        }
    }
}
