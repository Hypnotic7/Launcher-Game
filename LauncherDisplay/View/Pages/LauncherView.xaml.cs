using System.Windows.Controls;
using LauncherDisplay.View.Interfaces;

namespace LauncherDisplay.View.Pages
{
    public partial class LauncherView : Page, IDisplay
    {
        public MainWindow MainWindow { get; set; }
        public LauncherView(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            InitializeComponent();
        }

        public void Display()
        {
            MainWindow.MainFrame.NavigationService.Navigate(this);
        }
    }
}
