using System;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(8);
            shop[0].Model = "hpPavilion 2470p";
            shop[3].Model = "Lenovo 666x";
            shop[3].ReleaseDate = new DateTime(day: 13, month: 2, year: 1971);
            for (var i = 0; i < shop.Length; i++)
                Console.WriteLine(shop[i].ToString());

        }
    }
}
