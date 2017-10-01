using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Com
{
	class CustomCommand : ICommand
	{
		Data data;
		public CustomCommand()
		{}
		public CustomCommand(Data d)
		{
			data = d;
		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}


		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{		
			MessageBox.Show($"Пользовательская команда сработала: { data.Name } , { data.LastName}, { data.Country} ");

		}


	}
}
