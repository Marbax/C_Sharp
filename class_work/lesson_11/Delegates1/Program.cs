using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Таблица диапазонов времени суток ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("        1. 04:00-12:00            ");
            Console.WriteLine("        2. 12:00-17:00            ");
            Console.WriteLine("        3. 17:00-24:00            ");
            Console.WriteLine("        4. 00:00-04:00            ");
            Console.WriteLine("----------------------------------");

            Greeting g = new Greeting();
            Console.Write("\n> Выберите номер диапазона: ");
            try
            {
                int k = int.Parse(Console.ReadLine());
                if (k > 0 && k < 5)
                {
                    Console.WriteLine($"  => {g[k - 1].Invoke()}");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"  {err.Message}");
            }
            finally
            {
                Console.WriteLine("\nПрограмма завершена");
            }
        }
    }
}
