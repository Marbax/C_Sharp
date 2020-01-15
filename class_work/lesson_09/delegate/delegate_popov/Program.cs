using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_popov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("\tTime Table");
            Console.WriteLine("1)4:00-12:00");
            Console.WriteLine("2)12:00-17:00");
            Console.WriteLine("3)17:00-24:00");
            Console.WriteLine("4)24:00-4:00");
            Console.WriteLine("=============================================");

            Console.WriteLine("Select an time");
            Greeting greetings = new Greeting();
            try
            {
                int k = int.Parse(Console.ReadLine());

                if (k < 1 || k > 4) { throw new ApplicationException("Wrong choice"); }

                Console.WriteLine($" => {greetings[k - 1].Invoke()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\t\tError ! {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\n\t\tEnd of program");
            }
        }
    }
}
