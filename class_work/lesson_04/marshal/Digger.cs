using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    public class Digger : Worker
    {
        public Digger(string name, DateTime birthday, string organization, DateTime hire_date) :
    base(name, birthday, organization, hire_date)
        { Salary = 150; }

        public new void DoWork() // не будет доступен никогда через массив предков
        {
            Console.WriteLine($"Digger {Name} is diggint the pits all day long");
        }
    }
}
