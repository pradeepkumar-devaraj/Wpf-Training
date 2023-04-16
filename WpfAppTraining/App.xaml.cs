using System.Windows;

namespace WpfAppTraining
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            //validations any

            MainWindow win = new MainWindow();
            win.Show();
        }
    }
}
