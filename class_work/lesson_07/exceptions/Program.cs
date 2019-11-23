using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Program
    {
        static private int Div(int a = 10, int b = 0)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error! " + ex.Message);
                return Div(Input(), Input());
            }
        }

        static private int Sum(int a = 10, int b = 0)
        {
            try
            {
                return a + b;
            }
            catch (OverflowException over_ex)
            {
                Console.WriteLine($"Error! " + over_ex.Message);
                return Sum(Input(), Input());
            }
        }

        static private int Input()
        {
            try
            {
                checked
                {
                    int val = int.Parse(Console.ReadLine());
                    return val;
                }
            }
            catch (FormatException format_ex)
            {
                Console.WriteLine(format_ex.Message);
                throw new Exception(format_ex.Message, format_ex);
            }
            catch (OverflowException over_ex)
            {
                Console.WriteLine(over_ex.Message);
                return Input();
            }
        }
        static void Main(string[] args)
        {
            /*
            double res = 0;

            try
            {
                //res = Div(Input(), Input());
                res = Sum(Input(), Input());
                Console.WriteLine(res);
            }
            catch (Exception defex) when (defex.InnerException != null) { Console.WriteLine(defex.StackTrace); }
            catch (Exception def_ex) { Console.WriteLine(def_ex); }
            */

            //==============================finn===============
            Test_final fin = new Test_final { Name = "a_1" };
            if (true)
            {
                using (Test_final fin1 = new Test_final { Name = "b_1" })
                {
                    Console.WriteLine("using");
                }// вызывается диспос (деструктор) при выходе из области видимости
            }

            //===========================garbage_collector========================
            Console.WriteLine();
            Console.WriteLine(GC.GetTotalMemory(true));
            Console.WriteLine(GC.GetGeneration(fin));
            Console.WriteLine(GC.MaxGeneration);
            Console.WriteLine(GC.CollectionCount(0));
            Console.WriteLine("\nCORRECT ENDING\n");
        }
    }
}
