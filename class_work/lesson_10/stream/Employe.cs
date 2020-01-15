using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stream
{
    [Serializable]
    class Employe
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _position;

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private decimal _salary;

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public override string ToString()
        {
            return $"{Name,20}{Age,10}{Position,15}{Salary,10}";// ширина строки 20,10,15,10
        }
    }
}
