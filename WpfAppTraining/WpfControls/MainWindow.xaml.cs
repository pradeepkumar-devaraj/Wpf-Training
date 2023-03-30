using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfControls
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox c1 = sender as CheckBox;
                c1.Foreground = Brushes.Chartreuse;
            }
        }

        private void ToggleButton_OnUnchecked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox c1 = sender as CheckBox;
                c1.Foreground = Brushes.Blue;
            }
        }


        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (((ComboBoxItem)cb.SelectedValue).Content.ToString().Equals("Item 2"))
            {
                cb.Foreground = Brushes.Blue;
            }
        }
    }
}
