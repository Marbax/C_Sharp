using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction { Num = 1, Denum = 2 };
            var b = new Fraction { Num = 1, Denum = 2 };

            Console.WriteLine(a);
            Console.WriteLine(b);

            var f = a + 2;
            Console.WriteLine(f);

            f++;
            Console.WriteLine(f);
            ++f;
            Console.WriteLine(!f);
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            // если стоит implicit преобразование
            Console.WriteLine(a); // сначала пытается преобразовать к стандартному типу , поэтому и дабл выводит, имплисит - зло

            Console.WriteLine((float)a);
            Fraction ss = (Fraction)0.67;
            Console.WriteLine(ss);
        }
    }
}
