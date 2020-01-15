using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test1
            DataManager dm = new DataManager();
            dm.LoadData();
            Console.WriteLine("OK");

            // Test2
            dm.Data.Display();
            dm.Data.Departments[0].Display();

            // Test3
            Console.WriteLine("\n> Введите данные нового сотрудника:");
            Console.Write("  Имя: ");
            string name = Console.ReadLine();
            Console.Write("  Возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("  Должность: ");
            string position = Console.ReadLine();
            Console.Write("  Зарплата: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Employee emp = new Employee
            {
                Name = name,
                Age = age,
                Position = position,
                Salary = salary
            };
            //dm.Data.Departments[0].AddEmployee(emp);
            //dm.SaveData();
            //Console.WriteLine("  Сотрудник успешно добавлен");

            // LINQ:
            // Найти сотрудников, старших 21 года:
            // -----------------------------------
            // 1 --> обычный способ
            foreach (Employee empp in dm.Data.Departments[0].Employees)
            {
                if (empp.Age < 23)
                    Console.WriteLine(empp);
            }

            // 2 --> LINQ:
            Console.WriteLine();
            var res = dm.Data.Departments[0].Employees
                .Where(e => e.Age > 21).ToList();
            foreach (var x in res)
                Console.WriteLine(x);

            Console.WriteLine("\nПрограмма завершена");
        }
    }
}
