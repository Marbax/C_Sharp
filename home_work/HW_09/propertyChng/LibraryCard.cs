using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace propertyChng
{
    class LibraryCard : INotifyPropertyChanged
    {
        private string _name;

        private Client _client;


        public LibraryCard(string name,Client client)
        {
            _name = name;
            _client = client;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != this._name)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Client Client
        {
            get { return _client; }
            set
            {
                if (value != this._client)
                {
                    _client = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"{Name}\n{Client}";
        }
    }
}

