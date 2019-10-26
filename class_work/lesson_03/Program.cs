using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Petro", new DateTime(1999, 07, 25)); // вариант добавления даты
            Console.WriteLine(a);

            Person b = new Person();
            Console.WriteLine(b);

            Person c = new Person(birthday: new DateTime(day: 1, month: 07, year: 1992), _name: "Petro"); // именованые параметры
            Console.WriteLine(c);
            c.Name = "Fridrih";
            Console.WriteLine(c.Name);
            Console.WriteLine(c);

            Console.WriteLine();
            Console.WriteLine("bday = " + c.Birthday + ", counter = " + Person.Counter + ", Planet = " + Person.Planet);
            Console.WriteLine();

            c.LastName = "Muppet";
            Console.WriteLine(c);
        }
    }
}
