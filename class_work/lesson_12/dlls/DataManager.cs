using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompany;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace dlls
{
    class DataManager
    {
        private BinaryFormatter bf = new BinaryFormatter();

        private string _depsFilepATH;
        public string DepsFilePath
        {
            get { return _depsFilepATH; }
            set { _depsFilepATH = value; }
        }

        private string _empsFilePath;
        public string EmpsFilePath
        {
            get { return _empsFilePath; }
            set { _empsFilePath = value; }
        }

        public List<Department> Departments { get; set; }

        public List<Employee> Employments { get; set; }

        public DataManager(string DepFilePath = @"..\..\Data\departpents.dat",
            string EmpFilePath = @"..\..\Data\employments.dat")
        {
            EmpsFilePath = EmpFilePath;
            DepsFilePath = DepFilePath;
            Departments = new List<Department>();
            Employments = new List<Employee>();
            InitData();
            SaveData();
            //LoadData();
        }

        private void InitData()
        {
            InitializeDepartments();
            InitializeEmployee();
        }
        private void InitializeDepartments()
        {
            Departments.Add(new Department { Id = 1, Name = "Developers" });
            Departments.Add(new Department { Id = 2, Name = "Admins" });
            Departments.Add(new Department { Id = 3, Name = "Media" });
            //dep.ForEach(x => departmentBindingSource.Add(x));

        }
        private void InitializeEmployee()
        {
            Employments.Add(new Employee
            {
                Id = 1,
                DepId = 1,
                Photo = @"..\..\EmpPhoto\IvanIvanov.jpg",
                Name = "Ivan Ivanov",
                Birth = new DateTime(year: 1994, month: 4, day: 15),
                Entry = new DateTime(year: 2016, month: 4, day: 15),
                Fire = "-",
                Position = "Developer",
                Salary = 500
            });
            Employments.Add(new Employee
            {
                Id = 2,
                DepId = 2,
                Photo = @"..\..\EmpPhoto\LarisaPahom.jpg",
                Name = "Larisa Pahom",
                Birth = new DateTime(year: 1985, month: 4, day: 15),
                Entry = new DateTime(year: 2012, month: 2, day: 25),
                Fire = "-",
                Position = "L3 Admin",
                Salary = 2000
            });
            Employments.Add(new Employee
            {
                Id = 3,
                DepId = 3,
                Photo = @"..\..\EmpPhoto\ShnurovOleg.jpg",
                Name = "Shnurov Oleg",
                Birth = new DateTime(year: 1974, month: 4, day: 15),
                Entry = new DateTime(year: 2018, month: 4, day: 15),
                Fire = "-",
                Position = "PR manager",
                Salary = 1200
            });


            //emp.ForEach(x => employeeBindingSource.Add(x));
        }

        private void LoadData()
        {
            try
            {
                LoadEmployeeData();
                LoadDepartmentsData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void LoadEmployeeData()
        {
            using (FileStream fs = new FileStream(EmpsFilePath, FileMode.Open))
            {
                Employments = (List<Employee>)bf.Deserialize(fs);
            }
        }
        private void LoadDepartmentsData()
        {
            using (FileStream fs = new FileStream(DepsFilePath, FileMode.Open))
            {
                Departments = (List<Department>)bf.Deserialize(fs);
            }
        }
        private void SaveData()
        {
            try
            {
                SaveDepartmentsData();
                SaveEmployeeData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void SaveDepartmentsData()
        {
            using (FileStream fs = new FileStream(DepsFilePath, FileMode.Create))
            {
                bf.Serialize(fs, Departments);
            }
        }
        private void SaveEmployeeData()
        {
            using (FileStream fs = new FileStream(EmpsFilePath, FileMode.Create))
            {
                bf.Serialize(fs, Employments);
            }
        }

    }
}
