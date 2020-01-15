using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_popov
{
    delegate string GretingDelegate();

    class Greeting
    {
        GretingDelegate[] _greetings;
        public GretingDelegate this[int index] { get => _greetings[index]; /*set => _greetings[index] = value;*/ }

        public Greeting()
        {
            _greetings = new GretingDelegate[] { GoodMorning, GoodAfternoon, GoodEvening, GoodNight };
        }

        public string GoodMorning()
        {
            return "Good Morning";
        }
        public string GoodAfternoon()
        {
            return "Good Afternoon";
        }
        public string GoodEvening()
        {
            return "Good Evening";
        }
        public string GoodNight()
        {
            return "Good Night";
        }

    }
}
