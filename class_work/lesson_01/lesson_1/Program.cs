using System; // использование пространства имен
//using System.Collections.Generic; // аналог контейнеров stl


namespace lesson_1
{
    class Program
    {
        static void Main(string[] args) // статик метод вызызвается без обьекта класса , обязательно
        {
            System.Console.WriteLine("Hello world");
            Console.WriteLine("Helo world with def namespace");
            Console.WriteLine("What is your name ? ");

            // все считывается строкой , а потом уже преобразовуется
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " !");

            Console.WriteLine("How old are you? ");


            Console.ReadLine();
        }

        static void ConvertExp()
        {
            string name;
            int age;
            // общее преобразование 
            age = Convert.ToInt32(name = Console.ReadLine());

            // такой же ,тоже вылелетит если будут буквы
            age = int.Parse(name = Console.ReadLine());

            // не выкинет исключение , если не выйдет - выведет ноль
            int.TryParse(name = Console.ReadLine(), out age);

            if (int.TryParse(name = Console.ReadLine(), out age))
                Console.WriteLine("Age is " + age + " .");
            else
                Console.WriteLine("Error");
        }


        static void SumExp()
        {
            string name;
            int val, val1, result;
            if (int.TryParse(name = Console.ReadLine(), out val) && int.TryParse(name = Console.ReadLine(), out val1))
            {
                result = val + val1;
                Console.WriteLine("Age is " + val + " + " + val1 + " = " + result);
            }
            else
                Console.WriteLine("Error");
        }

        static void TernarExp()
        {
            string name;
            int val, val1, result;
            if (int.TryParse(name = Console.ReadLine(), out val) && int.TryParse(name = Console.ReadLine(), out val1))
            {
                // обязательно куда то нужно записывать val > val1 ? val : val1 так нельзя
                result = val > val1 ? val : val1;
                Console.WriteLine("Age is " + val + " and  " + val1 + " bigger " + result);
            }
            else
                Console.WriteLine("Error");
        }

        static void ForeEachExp()
        {
            string str = "Hello";
            foreach (var item in str)
                Console.WriteLine(item);
        }

        static void PrimeCheck()
        {
            int a;
            Console.WriteLine("Write num ");
            int.TryParse(Console.ReadLine(), out a);

            if (IsPrime(a))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");

        }

        static bool IsPrime(int a)
        {
            for (int i = 2; i < Math.Sqrt(a);)
                if (a % i == 0)
                    return false;
                else
                    return true;
            return false;

        }
    }
}