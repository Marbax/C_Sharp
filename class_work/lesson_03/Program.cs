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
            /*
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

            Console.WriteLine(Math.Sqrt(144));

            Console.WriteLine(Sum(1,'e','3','s'));

            string str = string.Format("one {0} two {1} three {2}",1,2,3); // это тоже внутри строка с переменным кол-вом параметров
            Console.WriteLine(str);
            Console.WriteLine();
            */

            Group array = new Group();
            Console.WriteLine(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();

            TestStruct obj;// = new TestStruct();
            obj._data = 6;
            obj.Data = 8;
            Console.WriteLine(obj.Data);
        }

        public static int Sum (params int []arr)// передача любого кол-ва параметров 
        {
            int sum=0;
            foreach (var i in arr)
                sum += i;

            return sum;
        }
    }
}
