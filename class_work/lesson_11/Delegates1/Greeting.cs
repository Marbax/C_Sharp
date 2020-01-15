using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    delegate string GreetingDelegate(); 

    class Greeting
    {
        GreetingDelegate[] gd;

        public GreetingDelegate this[int k]
        {
            get { return gd[k]; }
        }

        public Greeting()
        {
            gd = new GreetingDelegate[]
            {
                GoodMorning, GoodAfternoon, GoodEvening, GoodNight
            };
        }

        public string GoodMorning()
        {
            return "Доброе утро!";
        }

        public string GoodAfternoon()
        {
            return "Добрый день!";
        }

        public string GoodEvening()
        {
            return "Добрый вечер!";
        }

        public string GoodNight()
        {
            return "Доброй ночи!";
        }
    }
}
