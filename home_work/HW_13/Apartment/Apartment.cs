using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentLib
{
    [Serializable]
    public class Apartment
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _dayValue;

        public double DayValue
        {
            get { return _dayValue; }
            set { _dayValue = value; }
        }


        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private List<string> _photos;

        public List<string> Photos
        {
            get { return _photos; }
            set { _photos = value; }
        }

        private DateTime _arrivalDate;

        public DateTime ArrivalDate
        {
            get { return _arrivalDate; }
            set { _arrivalDate = value; }
        }

        private DateTime _departureDate;

        public DateTime DepartureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; }
        }

        public Apartment(string name = "", string description = "", double dayValue = default, DateTime arrivalDate = default, DateTime departureDate = default, params string[] photos)
        {
            _name = name;
            _description = description;
            _dayValue = dayValue;
            _arrivalDate = arrivalDate;
            _departureDate = departureDate;
            _photos = new List<string>();

            if (photos.Length > 0)
                foreach (var item in photos)
                    _photos.Add(item);

        }

    }
}
