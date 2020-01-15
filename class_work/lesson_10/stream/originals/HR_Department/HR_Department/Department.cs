using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department
{
    [Serializable]
    class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } =
            new List<Employee>();

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }

        public void DelEmployee(string name)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.Name == name)
                {
                    Employees.Remove(emp);
                    break;
                }
            }
        }

        public void Display()
        {
            int N = Employees.Count;
            if (N == 0)
            {
                Console.WriteLine("В отделе нет сотрудников");
            }
            else
            {
                Console.WriteLine($"Отдел - {Name}");
                Console.WriteLine("---------------------------------------");
                int k = 0;
                foreach (Employee emp in Employees)
                {
                    k++;
                    Console.WriteLine($"{k}. {emp}");
                }
            }
        }
    }
}
