using System;

namespace properties
{
    class Laptop
    {
        private string _model;
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        private DateTime _release_date;
        public DateTime ReleaseDate
        {
            get => _release_date;
            set => _release_date = value;
        }

        public Laptop() : this("UNKNOWN",new DateTime(1,1,1)) { }
        public Laptop(string _model, DateTime _release_date)
        {
            this._model = _model;
            this._release_date = _release_date;
        }

        public override string ToString()
        {
            return $"Model: {_model}\n" +
                $"Release date: {_release_date.ToLongDateString()}\n";
        }
    }
}
