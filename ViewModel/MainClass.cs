using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.ViewModel
{
	public class MainClass : INotifyPropertyChanged
	{
		public string name { get; set; }
		public string surname { get; set; }
		public DateTime date { get; set; }

		private string _intName { get; set; }
		private string _IntSurname { get; set; }
		private DateTime _IntDate { get; set; }
		

		public void SaveClick()
		{
			_intName = name;
			_IntSurname = surname;
			_IntDate = date;
		}

		public void RecoveryClick()
		{
			name = _intName;
			surname = _IntSurname;
			date = _IntDate;
			OnPropertyChanged(propertyName: nameof(name));
			OnPropertyChanged(propertyName: nameof(surname));
			OnPropertyChanged(propertyName: nameof(date));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(propertyName);
			return true;
		}
	}
}
