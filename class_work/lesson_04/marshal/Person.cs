using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marshal
{
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public Person(string name = "NONAME", DateTime birthday = new DateTime()) { }

        public override string ToString()
        {
            return $"Name: {Name} Birthday: {Birthday}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Person))
                return false;

            return base.Equals(obj) || (Name == ((Person)obj).Name && Birthday == ((Person)obj).Birthday);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _birthday.GetHashCode(); // что то не то
        }

    } 
}
