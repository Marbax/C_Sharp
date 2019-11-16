using System;

namespace auto
{
    namespace Complex
    {
        class Program
        {
            static void Main(string[] args)
            {
                Complex z = new Complex(1, 1);
                Complex z1; z1 = z - (z * z * z - 1) / (3 * z * z);
                Console.WriteLine($"z1 = { z1}");

                //--------------------------------------------------------------------------------------------

                Console.WriteLine("\n========_auto_============\n");
                auto a = new auto(15);
                auto b = new auto("Hello");
                auto c = new auto(7.8);
                auto d = new auto("50");
                b = a + d;
                Console.WriteLine(b);// Выведет 65 
                if (a == d) Console.WriteLine("Equal");
                else Console.WriteLine("Not Equal");

                auto a1 = new auto(10), b1 = new auto("120"), c1;
                c1 = a1 + b1;
                Console.WriteLine(c1); // Выведет 130  
                c1 = b1 + a1;
                Console.WriteLine(c1); // Выведет “12010” 

                auto a2 = new auto("Microsoft"), b2 = new auto("Windows"), c2;
                c2 = a2 * b2;
                Console.WriteLine(c2); // Выведет “ioso” 

                auto a3 = new auto("Microsoft"), b3 = new auto("Windows"), c3;
                c3 = a3 / b3;
                Console.WriteLine(c3); // Выведет “Mcrft” 


                Console.WriteLine();
            }
        }
    }
}
