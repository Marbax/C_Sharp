using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    /*
     * Разработайте консольный арифметический калькулятор
     * с циклом перезапуска вычислений на основе делегата и, обязательно, 
     * - без использования конструкций switch или if-else
     */

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DeleCalc calc = new DeleCalc();
                double a, b;
                bool active = true;
                while (active)
                {
                    try
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("            Calc                  ");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("           1. Sum                 ");
                        Console.WriteLine("           2. Sub                 ");
                        Console.WriteLine("           3. Multy               ");
                        Console.WriteLine("           4. Div                 ");
                        Console.WriteLine("----------------------------------");

                        Console.Write("Enter first value => ");
                        a = double.Parse(Console.ReadLine());

                        Console.Write("Enter second value => ");
                        b = double.Parse(Console.ReadLine());

                        Console.Write("\n> Choose operation: ");

                        int k = int.Parse(Console.ReadLine());

                        Console.WriteLine($" Rsult => {calc[k - 1].Invoke(a, b)}");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"  {err.Message}");
            }
        }
    }
}
