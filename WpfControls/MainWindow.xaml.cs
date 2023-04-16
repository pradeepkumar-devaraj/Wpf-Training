using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            var result = MessageBox.Show("Do you want to close?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Image is clicked", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            tabControl.Background = Brushes.Chartreuse;
        }

        private void UIElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            tabControl.Background = Brushes.Transparent;
        }

        private void UIElement_OnKeyDown(object sender, KeyEventArgs e)
        {
            txtBox.Foreground = Brushes.Blue;
        }
    }
}
