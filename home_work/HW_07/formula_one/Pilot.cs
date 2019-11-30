using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_one
{
    class Pilot : IComparable
    {
        public string Name { get; set; }
        public short Age { get; set; }
        public string Team { get; set; }
        public int[] Points;
        public int this[int index] { get => Points[index]; set => Points[index] = value; }

        public Pilot(string name, short age, string team)
        {
            this.Name = name;
            this.Age = age;
            this.Team = team;
            this.Points = new int[20];
        }

        public int CompareTo(object obj)
        {
            return Points.Sum().CompareTo(((Pilot)obj).Points.Sum());
        }

        public string PrintPilotWithoutPoints()
        {
            return $"Name: {Name}" +
                $"\nAge: {Age}" +
                $"\nTeam: {Team}";
        }
        public override string ToString()
        {
            return PrintPilotWithoutPoints() +
                $"\nPoints: {Points.Sum()}";
        }

        public override bool Equals(object obj)
        {
            return obj is Pilot pilot &&
                   this == (Pilot)obj;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Pilot obj_l, Pilot obj_r)
        {
            return obj_l.Name == obj_r.Name && obj_l.Age == obj_r.Age && obj_l.Team == obj_r.Team;
        }

        public static bool operator !=(Pilot obj_l, Pilot obj_r)
        {
            return !(obj_l == obj_r);
        }



    }
}
