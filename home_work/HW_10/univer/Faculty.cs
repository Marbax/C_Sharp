using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    [Serializable]
    class Faculty
    {
        private List<Group> _groups;
        public List<Group> Groups
        {
            get { return _groups; }
            set { _groups = value; }
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Faculty(List<Group> groups = default, string name = "NONE")
        {
            _groups = groups;
            _name = name;
        }


        public Faculty(string name = "NONE", params Group[] groups)
        {
            _groups = new List<Group>(groups);
            _name = name;
        }

        public override string ToString()
        {
            return $"Faculty: {_name}\n\t\tGroups:\n{_groups?.Select(x => x.ToString()).Aggregate((x, y) => x + "\n\n" + y)}";
        }


    }
}
