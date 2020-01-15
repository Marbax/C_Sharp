using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer
{
    [Serializable]
    class Student
    {
        private string _fname;

        public string FullName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        private DateTime _bday;
        public DateTime BirthDate
        {
            get { return _bday; }
            set
            {
                try
                {
                    if (value > DateTime.Now)
                        throw new ApplicationException($"\t\t\t\"{value.ToShortDateString()}\" is wrong date format! ");

                    _bday = value;
                }
                catch (ApplicationException ap_ex) { Console.WriteLine(ap_ex.Message); }
            }
        }
        public Student(string fname = "NONE", DateTime bday = default)
        {
            try
            {
                if (bday > DateTime.Now)
                    throw new ApplicationException($"\t\t\t\"{bday.ToShortDateString()}\" is wrong date format! ");

                _fname = fname;
                BirthDate = bday;
            }
            catch (ApplicationException ap_ex) { Console.WriteLine(ap_ex.Message); }
        }

        public override string ToString()
        {
            return $"Full name : {_fname}\nBirth Date : {_bday.ToShortDateString()}";
        }
    }
}
