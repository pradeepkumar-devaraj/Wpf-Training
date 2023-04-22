using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;

namespace WpfDataBinding
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private string _name;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<EmployeeModel> EmployeeList { get; set; } = new ObservableCollection<EmployeeModel>();

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

        public int Age { get; set; }

        public ICommand UpdateCommand { get; }

        public ICommand AddEmployeeCommand { get; }

        public ICommand FetchDataCommand { get; }

        public EmployeeViewModel()
        {
            UpdateCommand = new RelayCommand(UpdateName, CanUpdate);
            AddEmployeeCommand = new RelayCommand(AddEmployee);
            FetchDataCommand = new RelayCommand(FetchData);
            EmployeeList.Add(new EmployeeModel { Name = "Emp 1", Age = 19 });
            EmployeeList.Add(new EmployeeModel { Name = "Emp 2", Age = 25 });
            EmployeeList.Add(new EmployeeModel { Name = "Emp 3", Age = 45 });
        }

        private void FetchData()
        {
            Thread.Sleep(3000);
            Name = "Data Fetch Completed";
        }

        private void AddEmployee()
        {
            EmployeeList.Add(new EmployeeModel { Name = this.Name, Age = this.Age });
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
