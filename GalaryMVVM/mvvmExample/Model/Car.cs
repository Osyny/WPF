using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmExample.Model
{
	//2. Create model
	class Car
    {
        public String Model { get; set; }
		public String Name { get; set; }
		public int Year { get; set; }
		public String Image { get; set; }

		public ObservableCollection<string> Tag { get; set; } = new ObservableCollection<string>();
    }
}
