using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentLib;

namespace ClientLib
{
    [Serializable]
    public class Client
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _phoneNum;
        public string PhoneNumber
        {
            get { return _phoneNum; }
            set { _phoneNum = value; }
        }

        private List<Apartment> _history;
        public List<Apartment> History
        {
            get { return _history; }
            set { _history = value; }
        }


        public Client(string name = "", string phoneNum = "", params Apartment[] history)
        {
            _name = name;
            _phoneNum = phoneNum;
            _history = new List<Apartment>();

            foreach (var item in history)
                _history.Add(item);
        }

    }
}
