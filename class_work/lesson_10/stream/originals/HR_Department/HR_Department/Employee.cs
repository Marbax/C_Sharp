using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department
{
    [Serializable]
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Name, 20}{Age, 10}{Position, 15}{Salary, 10}";
        }
    }
}
