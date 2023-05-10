
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PhoneApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _surname;
        private DateTime _date = DateTime.Now;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (_surname != value)
                {
                    _surname = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime Date
        {
            get => _date;
            set
            {
                if (_date != value)
                {
                    _date = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand SaveCommand { get; set; }
        public ICommand RecoveryCommand { get; set; }

        public MainViewModel()
        {
            SaveCommand = new Command(() =>
            {
                Person.Name = Name;
                Person.Surname = Surname;
                Person.Date = Date;
            });

            RecoveryCommand = new Command(() => {
                Name = Person.Name;
                Surname = Person.Surname;
                Date = Person.Date;
            });
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
