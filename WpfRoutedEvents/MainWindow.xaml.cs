using System.Windows;

namespace WpfRoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick_Button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked handled in Button", "info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ButtonBase_OnClick_StackPanel(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked handled in SackPanel", "info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ButtonBase_OnClick_Grid(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked handled in Grid", "info", MessageBoxButton.OK, MessageBoxImage.Information);
            e.Handled = true;
        }
    }
}
