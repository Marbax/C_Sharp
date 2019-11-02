using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point2D p3d = new Point3D(1, 3, 6); // move не будет трогать поле Z , т.к. в его методе не известно об этом параметре
            p3d.move(4);
            Console.WriteLine(p3d);
            */

            Employee[] company = new Employee[5];
            Random rnd = new Random();
            for (int i = 0; i < company.Length; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        company[i] = new Manager(
                            name: "Manager_" + i,
                            birthday: new DateTime(year: rnd.Next(1989, 1999), month: rnd.Next(1, 12), day: rnd.Next(1, 28)),
                            organization: "MyCompany",
                            hire_date: new DateTime(year: rnd.Next(2005, 2019), month: rnd.Next(1, 12), day: rnd.Next(1, 28)));
                        break;
                    case 1:
                        company[i] = new Worker(
                           name: "Worker_" + i,
                           birthday: new DateTime(year: rnd.Next(1989, 1999), month: rnd.Next(1, 12), day: rnd.Next(1, 28)),
                           organization: "MyCompany",
                           hire_date: new DateTime(year: rnd.Next(2005, 2019), month: rnd.Next(1, 12), day: rnd.Next(1, 28)));
                        break;
                    case 2:
                        company[i] = new Digger(
                           name: "Digger_" + i,
                           birthday: new DateTime(year: rnd.Next(1989, 1999), month: rnd.Next(1, 12), day: rnd.Next(1, 28)),
                           organization: "MyCompany",
                           hire_date: new DateTime(year: rnd.Next(2005, 2019), month: rnd.Next(1, 12), day: rnd.Next(1, 28)));
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in company)
            {
                Console.WriteLine();
                Console.WriteLine(item);
                item.DoWork();
            }

            /*
            foreach (var item in company)
            {
                try
                {
                    ((Manager)item).LookingIntoTheWindow();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); //(вариант не фонтан) если закоментить ,то для тех у кого нет данного метода - просто проигнорится
                    //throw;
                }
            }
            */

            /*
            foreach (var item in company)
            {
                Manager tmp = item as Manager; // более менее вариант
                if (tmp != null)
                    tmp.LookingIntoTheWindow();
            }
            */
            /*
            foreach (var item in company)
            {
                Manager tmp = item as Manager;
                (item as Manager)?.LookingIntoTheWindow(); // элвис или нул кондиш оператор , проверяет или есть внутри что то , 
                                               // и сразу преобразовует
                                             // аналог верхнего варианта но короче
            }
            */

            foreach (var item in company)
            {
                //if (item is Manager) // is проверка ,является ли итем тем Обьектом
                if (item is Manager tmp) // is проверка ,является ли итем тем Обьектом и сразу создает ее преобразованную копию
                {
                    tmp.LookingIntoTheWindow();
                }
            }

            //==================================================================

            Digger d = new Digger(
                           name: "Digger_",
                           birthday: new DateTime(year: rnd.Next(1989, 1999), month: rnd.Next(1, 12), day: rnd.Next(1, 28)),
                           organization: "MyCompany",
                           hire_date: new DateTime(year: rnd.Next(2005, 2019), month: rnd.Next(1, 12), day: rnd.Next(1, 28))); ;
            //(d as Employee)?.DoWork();// можно и не проверять
            ((Employee)d).DoWork();

            Console.WriteLine();
            Person a = new Person();
            Person b = new Person();
            //b.Name = "sss";
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode() + "\n" + b.GetHashCode());
        }
    }
}

