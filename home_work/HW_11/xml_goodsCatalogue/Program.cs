using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ваше задание - завершить разработку приложения  "Автоматизированный каталог товаров". 
 * Следует предусмотреть расширение функционала относительно операций с товарами: 
 * добавление и удаление товара,выборка товаров по производителю и по цене, поиск товара по наименованию. 
 * Приложение должно иметь консольное меню управления с циклом перезапуска.
 */

namespace xml_goodsCatalogue
{
    class Program
    {
        //Приложение должно иметь консольное меню управления с циклом перезапуска.
        static public void AddCategoryMenu(DataManager dm)
        {
            Console.Write("\n\tEnter category name => ");
            string new_category = Console.ReadLine();
            if (!dm.GetCategoriesList().Exists(x => x.Attribute("name").Value == new_category))
            {
                dm.AddCategory(new_category);
                Console.WriteLine("\n\n\tCategory succesfully added");
            }
            else
                Console.WriteLine("\n\n\tCategory already exists");
        }

        static public void RemoveCategoryMenu(DataManager dm)
        {
            Console.Write("\n\tEnter the name of category which you would like to remove => ");
            string name_to_remove = Console.ReadLine();
            var id_to_remove = dm.GetCategoriesList().Where(c => c.Attribute("name").Value == name_to_remove).FirstOrDefault();

            if (id_to_remove != default && !dm.GetGoodsList().Exists(x => x.Attribute("cid").Value == id_to_remove.Attribute("id").Value))
            {
                if (dm.RemoveCategory(name_to_remove))
                    Console.WriteLine("\n\tCategory succesfully removed");
                else
                    Console.WriteLine("\n\n\tNo such category");
            }
            else
                Console.WriteLine("\n\tYou should remove all goods which are have that category at first\n\tOr there no such category");
        }
        static public void AddGoodMenu(DataManager dm)
        {
            try
            {
                Console.Write("\n\tEnter good's name => ");
                string new_goods_name = Console.ReadLine();

                Console.Write("\n\tEnter good's producer => ");
                string new_goods_producer = Console.ReadLine();

                Console.Write("\n\tEnter good's price => ");
                double new_goods_price = double.Parse(Console.ReadLine());

                Console.Write("\n\tEnter good's category => ");
                int new_goods_category = int.Parse(Console.ReadLine());


                if (dm.GetCategoriesList().Exists(x => x.Attribute("id").Value == new_goods_category.ToString()))
                {
                    if (!dm.GetGoodsList().Exists(x => x.Attribute("name").Value == new_goods_name &&
                    x.Attribute("producer").Value == new_goods_producer &&
                    x.Attribute("price").Value == new_goods_price.ToString()))
                    {
                        dm.AddGood(new_goods_name, new_goods_producer, new_goods_price, new_goods_category);
                        Console.WriteLine("\n\tGood succesfully added");
                    }
                    else
                        Console.WriteLine("\n\tSame good already exist's");
                }
                else
                    Console.WriteLine("\n\tNo such category\n");
            }
            catch (Exception)
            {
                Console.WriteLine("\n\tWrong input");
            }
        }

        static public void MainMenu()
        {
            var _dm = new DataManager();
            bool active = true;
            while (active)
            {

                Console.WriteLine("Press \"1\" to show Categories");
                Console.WriteLine("Press \"2\" to add Categorie");
                Console.WriteLine("Press \"3\" to remove Categorie");
                Console.WriteLine("Press \"4\" to show Goods");
                Console.WriteLine("Press \"5\" to show Goods by category");
                Console.WriteLine("Press \"6\" to show Goods by producer");
                Console.WriteLine("Press \"7\" to show Goods by price");
                Console.WriteLine("Press \"8\" to show Goods by name");
                Console.WriteLine("Press \"9\" to add Goods");
                Console.WriteLine("Press \"Backspace\" to Clear the screen");
                Console.WriteLine("Press \"Escape\" for Exit program");
                Console.Write("\n\n Your choice: ");
                //======

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine("\n\t\tList of categorise:");
                            _dm.PrintCategoriesList();
                            Console.WriteLine();
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            AddCategoryMenu(_dm);
                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            RemoveCategoryMenu(_dm);
                        }
                        break;
                    case ConsoleKey.D4:
                        {
                            Console.WriteLine("\n\t\tList of goods:");
                            _dm.PrintGoodsList();
                            Console.WriteLine();
                        }
                        break;
                    case ConsoleKey.D5:
                        {
                            Console.Write("\n\tEnter Goods category to search => ");
                            _dm.PrintGoodsByCategory(Console.ReadLine());
                            Console.WriteLine();
                        }
                        break;
                    case ConsoleKey.D6:
                        {
                            Console.Write("\n\tEnter Goods producer to search => ");
                            _dm.PrintGoodsByProducer(Console.ReadLine());
                            Console.WriteLine();
                        }
                        break;
                    case ConsoleKey.D7:
                        {
                            try
                            {
                                Console.Write("\n\tEnter exact Goods price or range to search  => ");
                                string answ = Console.ReadLine();
                                string[] answ_arr = answ.Trim().Split(" -".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                                if (answ_arr.Length > 2)
                                    throw new Exception();

                                if (answ_arr.Length == 1)
                                {
                                    _dm.PrintGoodsByPrice(double.Parse(answ_arr[0].Replace('.',',')));
                                }
                                else
                                {
                                    _dm.PrintGoodsByPrice(double.Parse(answ_arr[0].Replace('.', ',')), double.Parse(answ_arr[1].Replace('.', ',')));
                                }
                                Console.WriteLine();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n\tWrong input");
                            }
                        }
                        break;
                    case ConsoleKey.D8:
                        {
                            Console.Write("\n\tEnter Goods name to search => ");
                            _dm.SearchByGoodName(Console.ReadLine());
                            Console.WriteLine();
                        }
                        break;


                    case ConsoleKey.D9:
                        {
                            AddGoodMenu(_dm);
                        }
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        break;

                    case ConsoleKey.Escape:
                        active = false;
                        break;

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\nWrong choice!");
                        }
                        break;
                }


            }
            Console.WriteLine("\n\n\t\tProgram ended");
        }

        static void Main(string[] args)
        {
            MainMenu();

        }
    }
}
