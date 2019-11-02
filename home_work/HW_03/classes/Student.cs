using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Student
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _middlename;

        public string MiddleName
        {
            get { return _middlename; }
            set { _middlename = value; }
        }

        private string _group;

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private int[][] _arr_rating;

        public string getRating(int index)
        {
            StringBuilder str = new StringBuilder("");
            for (int i = 0; i < _arr_rating[index].Length; i++)
                str.Append(_arr_rating[index][i]).Append(" ");

            string str_cw = str.ToString();
            return str_cw;
        }
        public int getProgramming(int index) { return _arr_rating[0][index]; }
        public void addProgramming(int value)
        {
            int[] buf = _arr_rating[0];
            _arr_rating[0] = new int[_arr_rating[0].Length + 1];
            buf.CopyTo(_arr_rating[0], 0);
            _arr_rating[0][_arr_rating[0].Length - 1] = value;
        }
        public void setProgramming(int index, int value)
        {
            if (index < _arr_rating[0].Length)
                _arr_rating[0][index] = value;
            else
                Console.WriteLine("Wrong index!");
        }
        public int getAdministrating(int index) { return _arr_rating[1][index]; }
        public void addAdministrating(int value)
        {
            int[] buf = _arr_rating[1];
            _arr_rating[1] = new int[_arr_rating[1].Length + 1];
            buf.CopyTo(_arr_rating[1], 0);
            _arr_rating[1][_arr_rating[1].Length - 1] = value;
        }
        public void setAdministrating(int index, int value)
        {
            if (index < _arr_rating[1].Length)
                _arr_rating[1][index] = value;
            else
                Console.WriteLine("Wrong index!");
        }
        public int getDesign(int index) { return _arr_rating[2][index]; }
        public void addDesign(int value)
        {
            int[] buf = _arr_rating[2];
            _arr_rating[2] = new int[_arr_rating[2].Length + 1];
            buf.CopyTo(_arr_rating[2], 0);
            _arr_rating[2][_arr_rating[2].Length - 1] = value;
        }
        public void setDesign(int index, int value)
        {
            if (index < _arr_rating[2].Length)
                _arr_rating[2][index] = value;
            else
                Console.WriteLine("Wrong index!");
        }

        public double getAvgRating(int index)
        {
            if (_arr_rating[index].Length > 0)
                return _arr_rating[index].Average();
            else
            {
                Console.Write("No rating");
                return 0;
            }
        }

        public Student() : this("NONAME", "NOSURNAME", "NOMIDDLENAME", "NOGROUP", 0) { }
        public Student(string _name, string _surname, string _middlename, string _group, int _age)
        {
            this._name = _name;
            this._surname = _surname;
            this._middlename = _middlename;
            this._group = _group;
            this._age = _age;

            _arr_rating = new int[3][];
            for (var i = 0; i < _arr_rating.GetLength(0); i++)
            {
                _arr_rating[i] = new int[0];
            }
        }

        public override string ToString()
        {
            return $"Name: {_name}\n" +
                $"Surname: {_surname}\n" +
                $"Middle name: {_middlename}\n" +
                $"Group: {_group}\n" +
                $"Age: {_age}\n" +
                $"Programming: {getRating(0)} ,avg {getAvgRating(0):.00}\n" +
                $"Administrating: {getRating(1)} ,avg {getAvgRating(1):.00}\n" +
                $"Design: {getRating(2)} ,avg {getAvgRating(2):.00}\n";
        }

    }
}
