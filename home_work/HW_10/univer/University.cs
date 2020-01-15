using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    [Serializable]
    class University
    {

        private List<Faculty> _faculties;
        public List<Faculty> Faculties
        {
            get { return _faculties; }
            set { _faculties = value; }
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public University(List<Faculty> faculties = default, string name = "NONE")
        {
            _faculties = faculties;
            _name = name;
        }


        public University(string name = "NONE", params Faculty[] faculties)
        {
            _faculties = new List<Faculty>(faculties);
            _name = name;
        }

        public override string ToString()
        {
            return $"University: {_name}\n\t\tFaculties:\n{_faculties?.Select(x => x.ToString()).Aggregate((x, y) => x + "\n\n" + y)}";
        }

    }
}
