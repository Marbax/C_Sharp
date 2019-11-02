using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    public abstract class Employee : Person
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        private string _organization;

        public string Organization
        {
            get { return _organization; }
            set { _organization = value; }
        }

        private DateTime _hire_date;

        public DateTime HireDate
        {
            get { return _hire_date; }
            set { _hire_date = value; }
        }

        public Employee(string name, DateTime birthday, string organization, DateTime hire_date, double salary)
        {
            Name = name;
            Birthday = birthday;
            Organization = organization;
            HireDate = hire_date;
            Salary = salary;
        }

        public abstract void DoWork();// чисто виртуальный метод

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Birthday: {Birthday.ToLongDateString()}\n" +
                $"Organization: {Organization}\n" +
                $"Hire Date: {HireDate.ToLongDateString()}\n" +
                $"Salary: {Salary}";
        }


    }
}
