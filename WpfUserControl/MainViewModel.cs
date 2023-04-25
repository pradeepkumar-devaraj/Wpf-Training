using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfDataBinding;

namespace WpfUserControl
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IViewModel _viewModelToDisplay;
        public event PropertyChangedEventHandler PropertyChanged;

        public IViewModel ViewModelToDisplay
        {
            get => _viewModelToDisplay;
            set
            {
                _viewModelToDisplay = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowEmployeeCommand { get; set; }

        public ICommand ShowStudentCommand { get; set; }
        public MainViewModel()
        {
            ShowEmployeeCommand = new RelayCommand(ShowEmployee);
            ShowStudentCommand = new RelayCommand(ShowStudent);
        }

        private void ShowStudent()
        {
            ViewModelToDisplay = new StudentViewModel { StudentName = "Student 1", StudentStatus = "Passed" };
        }

        private void ShowEmployee()
        {
            ViewModelToDisplay = new EmployeeViewModel { EmployeeAge = 20, EmployeeName = "Employee 1" };
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
