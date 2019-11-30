using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_one
{
    class Season
    {
        public int Year;
        public Team[] Teams;
        public int RaceNumber;

        public Season(int year, params Team[] teams)
        {
            try
            {
                if (teams.Length !=10)
                {
                    throw new ApplicationException($"Wrong teams count! There is {teams.Length} teams. Should be 10");
                }
                this.Year = year;
                this.Teams = teams;
                this.RaceNumber = 0;
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        // распределяет очки за гонку между пилотами. 
        public void Race()
        {
            Pilot[] pilots_arr = GetAllPilots();
            int[] points_arr = new int[10] { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };
            int[] prizers_positions = GetPrizesPositions();
            try
            {
                if (RaceNumber >= 20)
                {
                    throw new IndexOutOfRangeException("\nSeason ended, cannot start more races!\n");
                }
                for (int i = 0; i < prizers_positions.Length; i++)
                {
                    pilots_arr[prizers_positions[i]].Points[RaceNumber] = points_arr[i];
                    Console.WriteLine($"\n{i + 1} Position:\n" + pilots_arr[prizers_positions[i]].PrintPilotWithoutPoints() + $"\nPoints for race = {points_arr[i]}");
                }

                for (int i = 0, j = prizers_positions.Length; i < pilots_arr.Length; i++)
                {
                    if (!prizers_positions.Contains(i))
                    {
                        Console.WriteLine($"\n{j + 1} Position:\n" + pilots_arr[i].PrintPilotWithoutPoints() + $"\nPoints for race = 0");
                        j++;
                    }
                }
                Console.WriteLine();

                RaceNumber++;
            }
            catch (IndexOutOfRangeException index_ex)
            {
                Console.WriteLine(index_ex.Message);
            }
            catch (Exception def_ex)
            {
                Console.WriteLine(def_ex.Message);
            }
        }

        // возвращает текущего лидера чемпионата. 
        public Pilot Leader()
        {
            try
            {
                Pilot[] pilots_arr = GetLeaderBoard();
                return pilots_arr[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // возвращает пилота, который занимает pos позицию в турнирной таблице.
        public Pilot GetPilot(int pos)
        {
            try
            {
                Pilot[] pilots_arr = GetLeaderBoard();
                return pilots_arr[pos];
            }
            catch (IndexOutOfRangeException index_ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // возвращает текущее количество очков определенного пилота.
        public int GetPoints(Pilot obj)
        {
            try
            {
                return FindPilot(obj).Points.Sum();
            }
            catch (Exception)
            {
                throw;
            }

        }

        // возвращает среднее арифметическое количество очков определенного пилота.
        public double GetAvgPoints(Pilot obj)
        {
            try
            {
                int[] finded_pilot_points = FindPilot(obj).Points;
                int[] points_arr = new int[RaceNumber];
                for (int i = 0; i < points_arr.Length; i++)
                {
                    points_arr[i] = finded_pilot_points[i];
                }
                return points_arr.Average();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private int[] GetPrizesPositions()
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            int iterator = 0;
            while (iterator < 10)
            {
                int random_pos = rnd.Next(0, 20);
                if (!arr.Contains(random_pos))
                {
                    arr[iterator] = random_pos;
                    iterator++;
                }
            }
            return arr;
        }

        private Pilot[] GetAllPilots()
        {
            Pilot[] pilots_arr = new Pilot[20];
            for (int i = 0, j = 0; i < Teams.Length; i++)
            {
                pilots_arr[j] = Teams[i].Pilot1;
                j++;
                pilots_arr[j] = Teams[i].Pilot2;
                j++;
            }
            return pilots_arr;
        }

        private Pilot[] GetLeaderBoard()
        {
            Pilot[] pilots_arr = GetAllPilots();
            Array.Sort(pilots_arr);
            return pilots_arr;
        }

        private Pilot FindPilot(Pilot obj)
        {
            try
            {
                Pilot[] pilots_arr = GetAllPilots();
                for (int i = 0; i < pilots_arr.Length; i++)
                {
                    if (pilots_arr[i].Name.Contains(obj.Name))
                    {
                        return pilots_arr[i];
                    }
                }
                throw new ApplicationException($"\nNo such Pilot! :\n{obj}");
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
