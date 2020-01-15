using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_goodsCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var dm = new DataManager();
            dm.PrintCategoriesList();

            /*
            Console.WriteLine();
            dm.AddCategory("Souse");
            dm.PrintCategoriesList();
            */

            /*
            Console.WriteLine();
            dm.RemoveCategory("Souse");
            dm.PrintCategoriesList();
            */

            dm.SelectGoodsByCategory("Computers");
        }
    }
}
