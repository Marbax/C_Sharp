using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker a = new Worker { Name = "Worker" };
            IWork b = new Worker { Name = "IWorker" };
            IWork c = new Digger { Name = "Digger" };
            Console.WriteLine(a.Name);
            Console.WriteLine(((Worker)b).Name);
            Console.WriteLine(((Digger)c).Name);
            a.Work();
            b.Work();
            c.Work();
            //===============================================
            Console.WriteLine();
            Digger a1 = new Digger { Name = "Digger" };
            Worker b1 = new Digger { Name = "Worker_Digger" };
            IWork c1 = new Digger { Name = "IDigger" };
            Console.WriteLine(a1.Name);
            Console.WriteLine(((Worker)b1).Name);
            Console.WriteLine(((Digger)c1).Name);
            a1.Work();
            b1.Work();
            c1.Work();
            //===============================================
            Console.WriteLine();
            ISing a2 = new Singer { Name = "Singer" };
            ISing b2 = new Digger { Name = "Singer_Digger" };
            a2.Sing();
            b2.Sing();
            //===============================================
            Console.WriteLine();
            Random rnd = new Random();
            ISing[] chorus = new ISing[10];
            for (int i = 0; i < chorus.Length; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        chorus[i] = new Artist { Name = "Artist_" + i };
                        break;
                    case 1:
                        chorus[i] = new Singer { Name = "Singer_" + i };
                        break;
                    case 2:
                        chorus[i] = new Digger { Name = "Digger_" + i };
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in chorus)
            {
                item.Sing();
            }
            //===============================================_FIGURES
            Console.WriteLine();

            Canvas canv = new Canvas(12);
            for (int i = 0; i < canv.Length; i++)
            {
                Console.WriteLine(canv[i]);
            }

            Console.WriteLine("===================_SORTED_============");
            canv.Sort();
            /*for (int i = 0; i < canv.Length; i++)
            {
                Console.WriteLine(canv[i]);
            }*/
            foreach (var item in canv)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();


        }
    }
}
