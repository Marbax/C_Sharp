using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HR_Department
{
    class DataManager
    {
        BinaryFormatter bf = new BinaryFormatter();
        public Company Data { get; set; } = new Company();
        string path = @"..\..\company.dat";

        public void InitData()
        {
            Employee emp1 = new Employee
            {
                Name = "Василий Пупкин",
                Age = 21,
                Position = "Администратор",
                Salary = 1500
            };

            Employee emp2 = new Employee
            {
                Name = "Лиза Пупкина",
                Age = 27,
                Position = "Тестировщик",
                Salary = 1700
            };

            Department dep1 = new Department
            {
                Name = "Компьютерный отдел"
            };
            dep1.AddEmployee(emp1);
            dep1.AddEmployee(emp2);

            Data.AddDepartment(dep1);
            Data.Name = "IT-Academy STEP";
        }

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path,
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, Data);
            }
        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path,
                FileMode.OpenOrCreate, FileAccess.Read))
            {
                Data = (Company)bf.Deserialize(fs);
            }
        }
    }
}
