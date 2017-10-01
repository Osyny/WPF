using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace mvvmExample.ViewModel
{
    //5. Create Base class view Model
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]
                                            String propertyName = "")
        {
            PropertyChanged?.
                Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
        }

    }
}
