using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    [Serializable]
    class Group
    {

        private List<Student> _students;

        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private short _year;

        public short Year
        {
            get { return _year; }
            set
            {
                try
                {
                    if (value > 5 || value < 1)
                        throw new ApplicationException($"\t\t\t\"{value}\" is wrong year format! ");

                    _year = value;
                }
                catch (ApplicationException ap_ex) { Console.WriteLine(ap_ex.Message); }
            }
        }

        public Group(List<Student> students = default, string name = "NONE", short year = 1)
        {
            try
            {
                if (year > 5 || year < 1)
                    throw new ApplicationException($"\t\t\t\"{year}\" is wrong year format! ");

                _students = students;
                _name = name;
                _year = year;
            }
            catch (ApplicationException ap_ex) { Console.WriteLine(ap_ex.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }


        public Group(string name = "NONE", short year = 1, params Student[] students)
        {
            try
            {
                if (year > 5 || year < 1)
                    throw new ApplicationException($"\t\t\t\"{year}\" is wrong year format! ");

                _students = new List<Student>(students);
                _name = name;
                _year = year;
            }
            catch (ApplicationException ap_ex) { Console.WriteLine(ap_ex.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public override string ToString()
        {
            return $"Group: {_name}\nYear: {_year}\n\tStudents:\n{_students?.Select(x => x.ToString()).Aggregate((x, y) => x + "\n\n" + y)}";
        }


    }
}
