using System.Windows;
using System.Windows.Controls;
using LauncherDisplay.View.Interfaces;


namespace LauncherDisplay.View
{
    /// <summary>
    /// Interaction logic for CreateAccountView.xaml
    /// </summary>
    public partial class CreateAccountView : Page, IDisplay
    {
        private  MainWindow MainWindow { get; }
        public CreateAccountView(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            InitializeComponent();
        }

        private void BackToLoginTxt_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.NavigationService.Navigate(new LoginView(MainWindow));
        }

        public void Display()
        {
            MainWindow.MainFrame.NavigationService.Navigate(this);
        }
    }
}
