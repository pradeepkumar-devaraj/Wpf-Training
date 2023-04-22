using System.Windows;

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeViewModel viewModel = new EmployeeViewModel();


        public MainWindow()
        {
            InitializeComponent();

            DataContext = viewModel;
            viewModel.Name = "Name";
            viewModel.UpdateName();
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            viewModel.Name = "Updated Name";
        }

    }
}
