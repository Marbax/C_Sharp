using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_one
{
    class Team
    {
        public string Title { get; set; }
        public Pilot Pilot1 { get; set; }
        public Pilot Pilot2 { get; set; }

        public Team(string title, Pilot pilot1, Pilot pilot2)
        {
            this.Title = title;
            this.Pilot1 = pilot1;
            this.Pilot2 = pilot2;
        }
        public Team(string title, string name1, short age1, string name2, short age2)
        {
            this.Title = title;
            this.Pilot1 = new Pilot(name1, age1, title);
            this.Pilot2 = new Pilot(name2, age2, title);
        }

    }
}
