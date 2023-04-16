using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfDataBinding
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private string _name;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public ICommand UpdateCommand { get; }

        public EmployeeViewModel()
        {
            UpdateCommand = new RelayCommand(UpdateName, CanUpdate);
        }

        private bool CanUpdate()
        {
            return Name.Length > 0;
        }

        public void UpdateName()
        {
            Name = "New Name";
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
