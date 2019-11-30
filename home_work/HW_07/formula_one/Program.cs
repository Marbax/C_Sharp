using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_one
{
    class Program
    {
        /*
        Написать программу, позволяющую просматривать информацию о чемпионате формулы 
            1. Реализовать следующие классы:  
                Pilot:  
                    Поля: 
                    ▪ name; 
                    ▪ age; 
                    ▪ team; 
                    ▪ points[20].  
                Team:  
                    Поля: 
                    ▪ title 
                    ▪ pilot1; 
                    ▪ pilot2.
                Season:  
                    Поля: 
                    ▪ year; 
                    ▪ teams[10]. 
                    ▪ raceNumber 
                    Методы :
                    ▪ void Race() - распределяет очки за гонку между пилотами. 
                    ▪ Pilot Leader() - возвращает текущего лидера чемпионата. 
                    ▪ Pilot GetPilot(int pos) - возвращает пилота, который занимает pos позицию в турнирной таблице. 
                    ▪ int GetPoints(Pilot) - возвращает текущее количество очков определенного пилота. 
                    ▪ double GetAvgPoints(Pilot) - возвращает среднее арифметическое количество очков определенного пилота.
                
            Во всех методах предусмотреть обработку исключительных ситуаций.
        */

        static void CertainPilotByPosChoiceMenu(Season season)
        {
            bool menu_runnning = true;
            while (menu_runnning)
            {
                try
                {
                    Console.Write("\nEnter Pilot's position : ");
                    Console.WriteLine(season.GetPilot(int.Parse(Console.ReadLine())));
                    Console.WriteLine();
                    menu_runnning = false;
                }
                catch (Exception def_ex)
                {
                    Console.WriteLine("\n" + def_ex.Message);
                }
            }
        }

        static void CertainPilotPointsChoiceMenu(Season season)
        {
            bool menu_runnning = true;
            while (menu_runnning)
            {
                try
                {
                    Console.Write("\nEnter name of the pilot: ");
                    string name = Console.ReadLine();
                    if (name.Length < 3)
                    {
                        throw new ApplicationException("Name should be longer");
                    }
                    Console.WriteLine("\n" + season.GetPoints(new Pilot(name, 0, "")));
                    Console.WriteLine();
                    menu_runnning = false;
                }
                catch (Exception def_ex)
                {
                    Console.WriteLine("\n" + def_ex.Message);
                }
            }
        }
        static void CertainPilotPointsAverageChoiceMenu(Season season)
        {
            bool menu_runnning = true;
            while (menu_runnning)
            {
                try
                {
                    Console.Write("\nEnter name of the pilot: ");
                    string name = Console.ReadLine();
                    if (name.Length < 3)
                    {
                        throw new ApplicationException("Name should be longer");
                    }

                    Console.WriteLine("\n" + season.GetAvgPoints(new Pilot(name, 0, "")));
                    Console.WriteLine();
                    menu_runnning = false;
                }
                catch (Exception def_ex)
                {
                    Console.WriteLine("\n" + def_ex.Message);
                }
            }

        }


        static void Main(string[] args)
        {
            try
            {
                Team Mercedes = new Team("Mercedes AMG Petronas F1 Team", "Льюис Хэмилтон", 34, "Валттери Боттас", 30);
                Team Red_Bull = new Team("Red Bull Racing-TAG Heuer", "Даниэль Риккардо", 30, "Макс Ферстаппен", 22);
                Team Ferrari = new Team("Scuderia Ferrari", "Себастьян Феттель", 32, "Кими Райкконен", 40);
                Team Sahara = new Team("Sahara Force India F1 Team", "Серхио Перес", 29, "Эстебан Окон", 23);
                Team Martini = new Team("Williams Martini Racing", "Фелипе Масса", 38, "Лэнс Стролл", 21);
                Team McLaren = new Team("McLaren Honda F1 Team", "Фернандо Алонсо", 38, "Стоффель Вандорн", 27);
                Team Scuderia = new Team("Scuderia Toro Rosso", " Карлос Сайнс-мл", 25, "Даниил Квят", 25);
                Team Haas = new Team("Haas F1 Team", "Роман Грожан", 33, "Кевин Магнуссен", 27);
                Team Renault = new Team("Renault Sport Formula 1 Team", "Нико Хюлькенберг", 32, "Джолион Палмер", 28);
                Team Sauber = new Team("Sauber F1 Team", "Паскаль Верляйн", 25, "Маркус Эрикссон", 29);
                Season season = new Season(2017, Mercedes, Red_Bull, Ferrari, Sahara, Martini, McLaren, Scuderia, Haas, Renault, Sauber);

                bool running = true;
                while (running)
                {
                    try
                    {
                        Console.WriteLine("Press \"1\" for Start a new race");
                        Console.WriteLine("Press \"2\" for Show the leader of the season");
                        Console.WriteLine("Press \"3\" for Show the certain pilot by the position in the Leader Board");
                        Console.WriteLine("Press \"4\" for Show the certain's pilot's points");
                        Console.WriteLine("Press \"5\" for Show the certain's pilot's points average");
                        Console.WriteLine("Press \"6\" for Clear the screen");
                        Console.WriteLine("Press \"Escape\" for Exit program");
                        Console.Write("\n\n Your choice: ");
                        //======

                        var input = Console.ReadKey();
                        switch (input.Key)
                        {
                            case ConsoleKey.D1:
                                {
                                    season.Race();
                                }
                                break;
                            case ConsoleKey.D2:
                                {
                                    Console.WriteLine("\n\t\tSeason Leader is :");
                                    Console.WriteLine(season.Leader());
                                    Console.WriteLine();
                                }
                                break;
                            case ConsoleKey.D3:
                                {
                                    CertainPilotByPosChoiceMenu(season);
                                }
                                break;
                            case ConsoleKey.D4:
                                {
                                    CertainPilotPointsChoiceMenu(season);
                                }
                                break;
                            case ConsoleKey.D5:
                                {
                                    CertainPilotPointsAverageChoiceMenu(season);
                                }
                                break;


                            case ConsoleKey.D6:
                                Console.Clear();
                                break;

                            case ConsoleKey.Escape:
                                running = false;
                                break;

                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nWrong choice!");
                                }
                                break;
                        }
                    }
                    catch (Exception def_ex)
                    {
                        Console.WriteLine(def_ex.Message);
                    }
                }
            }
            catch (Exception outer_ex)
            {
                Console.WriteLine(outer_ex.Message);
            }
        }
    }
}
