using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stream
{
    [Serializable]
    class Company
    {
        public List<Department> Departments { get; set; } = new List<Department>();

        public void AddDepartment(Department dep)
        {
            Departments.Add(dep);
        }
        public void Display()
        {
            if (Departments.Count == 0)
                Console.WriteLine("Any departments");
            else
                Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"{Departments.Select(x => x.ToString()).Aggregate((x, y) => x + "\n\n" + y)}";
        }
    }
}
