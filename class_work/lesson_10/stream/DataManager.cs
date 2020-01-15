using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace stream
{
    class DataManager
    {
        BinaryFormatter bf = new BinaryFormatter(); // для записи и чтения обьекта
        public Company company { get; set; } = new Company();

        string _fPath = @"..\..\company.dat";

        public void InitData()
        {
            Employe emp1 = new Employe { Age = 27, Name = "Evgen Pupkina", Position = "Tester", Salary = 8000 };
            Employe emp2 = new Employe { Age = 31, Name = "Liza Pupkina", Position = "Admin", Salary = 5000 };
            Employe emp3 = new Employe { Age = 19, Name = "Vasya Pupkina", Position = "Programmer", Salary = 10000 };
            Employe emp4 = new Employe { Age = 33, Name = "Vasya Gorohov", Position = "Tester", Salary = 8000 };
            Employe emp5 = new Employe { Age = 44, Name = "Valera Vrach", Position = "Admin", Salary = 5000 };
            Employe emp6 = new Employe { Age = 42, Name = "Vasya Gorbach", Position = "Programmer", Salary = 10000 };
            Department dep1 = new Department { Name = "404group", Employes = new List<Employe> { emp1, emp2, emp3 } };
            Department dep2 = new Department { Name = "stepBack", Employes = new List<Employe> { emp4, emp5, emp6 } };
            company = new Company { Departments = new List<Department> { dep1, dep2 } };
        }

        public void SaveData()
        {
            using (FileStream fs = new FileStream(_fPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fs, company);
            }

        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(_fPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                company = (Company)bf.Deserialize(fs);
            }
        }
    }
}
