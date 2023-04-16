using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfAppTraining
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button b1 = new Button();
            b1.Height = 20;
            b1.Width = 300;
            b1.Background = Brushes.Chartreuse;
            b1.Content = "Code Button";
            this.RootGrid.Children.Add(b1);
            myButton.Content = "Content assigned from code";
            DataContext = this;
            Data.Add(new Employee { Age = 23, Name = "Emp1" });
            Data.Add(new Employee { Age = 25, Name = "Emp2" });

        }

        public ObservableCollection<Employee> Data { get; } = new ObservableCollection<Employee>();

        private void ClickEventHandler(object sender, RoutedEventArgs e)
        {

            if (sender is Button)
            {
                Button myButton = (Button)sender;
                myButton.Content = "My Button";
            }
            else if (sender is CheckBox)
            {
                CheckBox myCheckBox = (CheckBox)sender;
                myCheckBox.Content = "My CheckBox";
            }
        }

        private void Expander_OnExpanded(object sender, RoutedEventArgs e)
        {
            ((Expander)sender).Background = Brushes.Chartreuse;
        }

        private void Expander_OnCollapsed(object sender, RoutedEventArgs e)
        {
            ((Expander)sender).Background = Brushes.White;
        }

        private void ButtonBase_OnClick_Increase(object sender, RoutedEventArgs e)
        {
            VaryingTextBlock.FontSize++;
        }

        private void ButtonBase_OnClick_Decrease(object sender, RoutedEventArgs e)
        {
            VaryingTextBlock.FontSize--;
        }

    }
}
