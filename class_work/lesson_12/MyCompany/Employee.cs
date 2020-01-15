using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Entry { get; set; }
        public DateTime Fire { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int DepId { get; set; }
    }
}
