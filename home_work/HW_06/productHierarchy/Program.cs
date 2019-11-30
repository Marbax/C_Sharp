using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    class Program
    {
        /*
          Разработать архитектуру классов иерархии товаров 
          при разработке системы управления потоками товаров 
          для дистрибьюторской компании.
          Прописать члены классов.  
          Должны быть предусмотрены разные типы товаров, в том числе:
            - Бытовая химия; 
            - Продукты питания.
         Предусмотреть интерфейсы: 
            - Скоропортящиеся продукты; 
            - Ликеро-водочные продукты и табачные изделия(акцизные продукты); 
            - Легковоспламеняющиеся товары; 
            - Бьющиеся товары.
         Предусмотреть классы управления потоком товаров (пришло, реализовано, списано, передано). 
         Реализовать собственные классы исключений: 
            - “Нет в наличии”; 
            - “Истек срок годности”; 
            - “Бракованный товар”. 
        Продемонстрировать работу классов.
      */
        static void Main(string[] args)
        {
            AProduct prod = new Milk(endDate: new DateTime(2021, 1, 12));
            AProduct prod1 = (Milk)prod.Clone();
            Console.WriteLine();
            Console.WriteLine();
            AFlowControl flow = new ArrivedGoods(prod, prod1, new Milk(name: "V Malako"), new Rum(), new ToiletPaper());
            flow.Add(new Milk(name: "Sooooevoe"));

            // изменение нескольких обьектов
            ((Milk)prod).EndDate = new DateTime(1888, 1, 1);
            ((IPerishable)prod1).EndDate = new DateTime(1111, 1, 1);
            prod.Name = "some";
            prod.Value = 1231;

            // сравнение
            foreach (var item in flow)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine("=====================");
            Console.WriteLine("Trying to sale goods");

            AFlowControl flow1 = new SoldGoods(flow);
            flow1.AddRange(new Rum(), new ToiletPaper(), flow[0],flow[1],flow[2],flow[3],flow[4]);
            foreach (var item in flow1)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

        }
    }
}
