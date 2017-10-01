using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Com
{
	class Data : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private string lastName;
        private string country;
        private int countryIndex;
 
        public Data()
        {
            clear();
        }

        public List<string> Countries { get; set; } = new List<string> { "Ukraine", "Poland", "France", "Rumaine" };

        public string Name { get { return name; } set { name = value; OnPropertyChanged("Name"); } }

        public string LastName { get { return lastName; } set { lastName = value; OnPropertyChanged("LastName"); } }
        public string Country { get { return country; } set { country = value; } }
        public int CountryIndex { get { return countryIndex; } set { countryIndex = value; OnPropertyChanged("CountryIndex"); } }

        public void clear()
        {
            Name = "";
            LastName = "";
            CountryIndex = -1;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
