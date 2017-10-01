using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Com
{
	class ClearCommand : ICommand
	{
		Data data;

		public ClearCommand() { }
		public ClearCommand(Data d)
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
            data.clear();
			MessageBox.Show("команда Clear сработала!!! ");
		}
	}
}
