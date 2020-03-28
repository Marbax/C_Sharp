using System; // использование пространства имен
//using System.Collections.Generic; // аналог контейнеров stl


namespace lesson_1
{
    class Program
    {
        static void Main(string[] args) // статик метод вызызвается без метода класса , обязательно
        {
            //System.Console.WriteLine("Hello world");
            // Console.WriteLine("Helo world with def namespace");
            // cw // снипет (tab tab)
            //Console.WriteLine("What is your name ? ");
            //string name = Console.ReadLine(); // все считывается строкой , а потом уже преобразовуется
            //Console.WriteLine("Hello "+name + " !");

            //Console.WriteLine("How old are you? ");

            //-----------------------Конвертирование
            //int age = Convert.ToInt32(name = Console.ReadLine());// общее преобразование 
            //int age = int.Parse(name = Console.ReadLine()); // такой же ,тоже вылелетит если будут буквы
            //int age;
            //int.TryParse(name = Console.ReadLine(),out age);// не выкинет исключение , если не выйдет - выведет ноль

            //if (int.TryParse(name = Console.ReadLine(), out age)) // var вместо auto
            //{
            //    Console.WriteLine("Age is " + age + " .");

            //}
            //else
            //{
            //    Console.WriteLine("Error");

            //}
            //-----------------------END


            //--------------------------------- SUM
            //int val, val1,result;
            //if (int.TryParse(name = Console.ReadLine(), out val ) && int.TryParse(name = Console.ReadLine(), out val1)) // var вместо auto
            //{
            //    result = val + val1;
            //    Console.WriteLine("Age is " + val+ " + " + val1 + " = " + result);

            //}
            //else
            //{
            //    Console.WriteLine("Error");

            //}
            //---------------------------------- END

            //--------------------------------- TERNARN
            //int val, val1, result;
            //if (int.TryParse(name = Console.ReadLine(), out val) && int.TryParse(name = Console.ReadLine(), out val1)) // var вместо auto
            //{
            //    result = val > val1 ? val : val1; // обязательно куда то нужно записывать val > val1 ? val : val1 так нельзя

            //    Console.WriteLine("Age is " + val + " and  " + val1 + " bigger " + result);

            //}
            //else
            //{
            //    Console.WriteLine("Error");

            //}

            //-------------------------- FOR EACH
            //string str = "Hello";

            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //-------------------------- END FOR EACH


            int a;
            Console.WriteLine("Write num ");
            int.TryParse(Console.ReadLine(),out a);

            
                if (IsPrime(a))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }

            


            


            Console.ReadLine();
        }
        static bool IsPrime(int a )
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