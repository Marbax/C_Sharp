using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stream
{
    [Serializable]
    class Department
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<Employe> employes;

        public List<Employe> Employes { get; set; } = new List<Employe>();

        public void AddEmploye(Employe emp) { Employes.Add(emp); }

        public void InputNewEmploye()
        {
            Console.WriteLine("\nEnter new epmloye:");
            Console.Write("name = ");
            string empname = Console.ReadLine();

            Console.Write("age = ");
            int empnage = int.Parse(Console.ReadLine());

            Console.Write("position = ");
            string position = Console.ReadLine();

            Console.Write("salary = ");
            decimal salary = decimal.Parse(Console.ReadLine());

            AddEmploye(new Employe { Name = empname, Age = empnage, Position = position, Salary = salary });
            System.Console.Clear();
            Console.WriteLine("Employe added");

        }
        public void DelEmploye(string name)
        {
            Employes.Remove(Employes.First(x => x.Name == name));
        }

        public void Display()
        {
            if (Employes.Count == 0)
                Console.WriteLine("NONE");
            else
                Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Department : {Name} \nEmployes:\n{Employes.Select(x => x.ToString()).Aggregate((x, y) => x + "\n" + y)}";
        }
    }
}
