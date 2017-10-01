using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using mvvmExample.Model;
using System.Windows.Input;
using System.ComponentModel;

namespace mvvmExample.ViewModel
{
    //6. Create ViewModel and Bind!!!
    class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int yearWith;
        public int YearWiht
        {
            get {return yearWith; }
            set { yearWith = value; selectCarForYear(); }
        }

        private int yearTo;
        public int YearTo
        {
            get { return yearTo; }
            set { yearTo = value; selectCarForYear(); }
        }


        public MainWindowViewModel()
        {
            //7.1 Не бойтесь проверять себя!!!
          //  MessageBox.Show("sdfsdf");
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void updateCarsViewFromModel()
        {
            Cars = new ObservableCollection<Car>(Garage.AllCars);
        }

        //8. Соединяем Model i View
        ObservableCollection<Car> _cars;
        public ObservableCollection<Car> Cars {
            get
            {
                if (_cars == null)
                    updateCarsViewFromModel();
                return _cars;
                //return _cars =_cars??new ObservableCollection<Car>(Garage.AllCars);
            }
            set
            {
                _cars = value;
                OnPropertyChanged("Cars");
            }
        }
        //10. Create Command
        private ICommand _addCarCommand;
        public ICommand AddCommand
        {
            get {
                if (_addCarCommand == null)
                    _addCarCommand = 
                        //new RelayCommand(x => Cars.RemoveAt(0));
                        new RelayCommand(AddClick);
                return _addCarCommand;
            }
            set { _addCarCommand = value; }
        }
        void AddClick(object param)
        {
			//MessageBox.Show("sdf");
			Car newCar = new Car();
            Garage.AllCars.Add(newCar);
            updateCarsViewFromModel();
        }
// -----------------------------------------------  SORT COMMAND   ----------------------------------------
        //10. Create Command SORT BY NAME
        private ICommand sortCarByNameCommand;
        public ICommand sortByNameCommand
        {
            get  {
                if (sortCarByNameCommand == null)
                    sortCarByNameCommand =
                        //new RelayCommand(x => Cars.RemoveAt(0));
                        new RelayCommand(sortByName);
                return sortCarByNameCommand;  }
            set { sortCarByNameCommand = value; }
        }

        void sortByName(object param)
        {
            foreach (var i in Cars)
                Console.WriteLine($" Name - {i.Name} , Year- {i.Year}");
            Console.WriteLine(" ------------- ");

            Cars = new ObservableCollection<Car>(Cars.OrderBy(i => i.Name));

            foreach (var i in Cars)
                Console.WriteLine($" Name - {i.Name} , Year- {i.Year}");
            Console.WriteLine("/ ");
        }

        //10. Create Command SORT BY YEAR
        private ICommand sortCarByYEARCommand;
        public ICommand sortByYearCommand
        {
            get
            {
                if (sortCarByYEARCommand == null)
                    sortCarByYEARCommand =
                        //new RelayCommand(x => Cars.RemoveAt(0));
                        new RelayCommand(sortByYear);
                return sortCarByYEARCommand;
            }
            set { sortCarByYEARCommand = value; }
        }
        void sortByYear(object param)
        {
            foreach (var i in Cars)
                Console.WriteLine($" Name - {i.Name} , Year- {i.Year}");
            Console.WriteLine(" ------------- ");

            Cars = new ObservableCollection<Car>(Cars.OrderBy(i => i.Year));
       
            foreach (var i in Cars)
                Console.WriteLine($" Name - {i.Name} , Year- {i.Year}");

            Console.WriteLine("/ ");
        }

       
        //10. Create Command SORT BY Model
        private ICommand sortCarByModelCommand;
        public ICommand sortByModelCommand
        {
            get
            {
                if (sortCarByModelCommand == null)
                    sortCarByModelCommand =
                        //new RelayCommand(x => Cars.RemoveAt(0));
                        new RelayCommand(sortByModel);
                return sortCarByModelCommand;
            }
            set { sortCarByModelCommand = value; }
        }
        void sortByModel(object param)
        {
            foreach (var i in Cars)
                Console.WriteLine($" Name - {i.Name} , Year- {i.Year}");
            Console.WriteLine(" ------------- ");

            Cars = new ObservableCollection<Car>(Cars.OrderBy(i => i.Model));

            foreach (var i in Cars)
                Console.WriteLine($" Name - {i.Name} , Year- {i.Year}, Model - {i.Model}");

            Console.WriteLine("/ ");
        }

 // -----------------------------------------------  REMOVE COMMAND   ----------------------------------------
        private ICommand removeCarCommand;
		public ICommand RemoveCommand
		{
			get
			{
				if (removeCarCommand == null)
					removeCarCommand =
						//new RelayCommand(x => Cars.RemoveAt(0));
						new RelayCommand(RemoveClick);
				return removeCarCommand;
			}
			set { _addCarCommand = value; }
		}
		void RemoveClick(object param)
		{
            Garage.AllCars.Remove(param as Car);
            updateCarsViewFromModel();
			//MessageBox.Show("remove BTN!!!");
		}

// -----------------------------------------------  SELECT COMMAND FOR YEAR   ---------------------------------------------------
        //10. Create Command SELECT CAR FOR YEAR

		void selectCarForYear()
		{
            ObservableCollection<Car> resultList = new ObservableCollection<Car>();

            updateCarsViewFromModel();

            foreach(var i in Cars)
            {
                if(i.Year >= yearWith && (i.Year <= YearTo || YearTo < YearWiht || YearTo == 0))
                {
                    resultList.Add(i);
                }
             
            }
            Cars = resultList;
		}


		//11. Command for events
		private ICommand _windowClosingCommand;
        public ICommand WindowClosing
        {
            get
            {
                if (_windowClosingCommand == null)
                    _windowClosingCommand =
                        new RelayCommand(x => MessageBox.Show("Bye-bye"));
                return _windowClosingCommand;
            }
            set { _windowClosingCommand = value; }
        }


    }
}
