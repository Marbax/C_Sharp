using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{

    public delegate void Greeting();

    public delegate double Calc(double a, double b);

    class Test
    {
        public void Hi()
        {
            Console.WriteLine("Hi");
        }

        private void Hello()
        {
            Console.WriteLine("Hello");
        }

        public void SetDlg(out Greeting obj)
        {
            obj = Hello;
        }
    }

    class MyClac
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mult(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException();
        }
    }

    public static class ExMeth
    {
        public static int WordsCoutner(this string str)
        {
            return str.Split(",/. ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }


    public delegate void NotoficationType(string msg);

    class News
    {
        /*
        public event NotoficationType Notification;
        

        public void Notify(string msg)
        {
            Notification?.Invoke(msg); // если ненул - делегировать
        }
        */

        public EventHandler Notification;
        public void Notify()
        {
            Notification?.Invoke(this, EventArgs.Empty); // сообщает что что то  произошло
        }

    }

    class Subscriber
    {
        public string Name { get; set; }

        /*
        public void GetNotification(string msg)
        {
            Console.WriteLine($"{Name} has got notification. \n Message: {msg}");
        }
        */
        public void GetNotification(object s, EventArgs a)
        {
            Console.WriteLine($"{Name} has got notification");
        }

    }


    class Program
    {

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static int Comparer(int a, int b)
        {
            return b - a;
        }

        public static string ConvertToString(int val)
        {
            return val.ToString();
        }

        static void Main(string[] args)
        {
            // Greeting a = new Greeting(Hello);// полная запись
            Greeting a = Hello; // то же самое ,но еороче

            Console.WriteLine();
            Test obj = new Test();
            Greeting b = obj.Hi;
            a.Invoke(); // полная запись
            b(); // то же самое, но короче


            Console.WriteLine();
            Greeting c;
            obj.SetDlg(out c); // присвоение вдреса приватного метода 
            c();

            Console.WriteLine();
            a += b;
            a += c;
            a();

            Console.WriteLine();
            Calc calc = MyClac.Sub;
            MyClac clc = new MyClac();
            calc += clc.Div;
            calc += clc.Mult;
            calc += clc.Sum;
            Console.WriteLine(calc(12, 2)); // вызовет последний добавленый метод (не стоит юзать)

            Console.WriteLine();
            foreach (Calc item in calc.GetInvocationList())
            {
                Console.WriteLine(item(12, 2));
            }

            /*
            Console.WriteLine();
            foreach (var item in calc.GetInvocationList())
            {
                Console.WriteLine(item.DynamicInvoke(12, 2)); // медленее , и проверки на этапе компиляции , в 10 дольше , лучше не юзать
            }
            */

            Console.WriteLine();
            Random rnd = new Random();
            List<int> lst = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                lst.Add(rnd.Next(10, 2000));
            }
            lst.Sort(Comparer); // принимает адресс ф-и сравнения
            foreach (var item in lst)
            {
                Console.Write($"{item} ");
            }


            Console.WriteLine("\n\n");
            var lst_str = lst.ConvertAll(ConvertToString); // принимает адрес ф-и конвертирования обьекта
            foreach (var item in lst_str)
            {
                Console.Write($"{item} ");
            }



            Console.WriteLine("\n\n");
            lst.Sort(delegate (int num1, int num2) { return num1 + num2; }); // анонимная ф-я , чтобы не писать кучу ф-й , хуже чем лямбды

            Console.WriteLine();
            lst.Sort((v1, v2) => v1 - v2); // лямбда ф-я ,короче анонимок

            var lst_str_new = lst.ConvertAll(x => x.ToString());
            //var lst_str_select = lst.Select(ls => ls.ToString()).ToList(); // аналог ,но работает с любыми данными
            var lst_str_select = lst.Select(ls =>
            {
                if (ls % 2 == 0)
                    return ls + 1;
                return ls;
            }); // если не парное чилос ,возвращает его +1 ,если парное - просто возвращает

            Console.WriteLine();
            var res = from x in lst
                      where x % 2 == 0
                      select x; // linq запросы ,похожы на sql (хранит запрос,каждый раз его выполняет)
            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }


            Console.WriteLine("\n\n");
            var res_copy = (from x in lst
                            where x % 2 == 0
                            select x).ToList(); // создает копию того ,что выдаст запрос

            var res_lst = lst.Where(var1 => var1 % 2 == 0); // то же что linq запрос выше с возвратом четных чисел


            Console.WriteLine("\n\n");
            string poem = "asd asda sa ag ";
            Console.WriteLine(poem.WordsCoutner()); // использование раширеного метода для строки 

            Console.WriteLine(lst.Sum()); // на самом деле это linq запрос 



            Console.WriteLine("\n\n");
            var res00 = from x in lst
                        let tmp = lst.Average()
                        where x < tmp
                        select x; // linq запрос в мануальном запросе , выводит элемменты которые меньше среднего размера еллемента

            foreach (var item in res00)
            {
                Console.Write($"{item} ");
            }


            Console.WriteLine("\n\n");
            Console.WriteLine(res00.Aggregate((x, y) => x + y)); // возвращает одно значение ,резульимрующее всех


            Console.WriteLine("\n\n");
            foreach (var item in lst)
            {
                Console.Write($"{item} ");
            }


            // разбиение массива многозначных чисел , на массив одозначных чисел ("123"=>'1','2','3')
            var ciphers = lst.Select(x => x.ToString()).Aggregate((x, y) => x + y).Select(x => int.Parse(x.ToString()));
            // приобразуем цифры в строки ,потом строки в большую строку , потом парсит каждый чар преобразуется в число и ложится в новый массив


            Console.WriteLine("\n\ncIphers");

            foreach (var item in ciphers)
            {
                Console.Write($"{item} ");
            }



            Console.WriteLine("\n\n");
            News news = new News();
            Subscriber sub1 = new Subscriber { Name = "Ivan" };
            Subscriber sub2 = new Subscriber { Name = "Petro" };
            Subscriber sub3 = new Subscriber { Name = "Luda" };
            Subscriber sub4 = new Subscriber { Name = "Mila" };

            news.Notification += sub1.GetNotification;
            news.Notification += sub2.GetNotification;
            news.Notification += sub3.GetNotification;
            news.Notification += sub4.GetNotification;

            news.Notification += (s, e) => (Console.WriteLine("NOtification"););
            news.Notify();



        }
    }
}
