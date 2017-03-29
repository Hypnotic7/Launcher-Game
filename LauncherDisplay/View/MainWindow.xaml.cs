using System.Windows;
using LauncherDisplay.Controller;
using LauncherDisplay.Model;
using LauncherDisplay.View;

namespace LauncherDisplay
{
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
            LoginController loginController = new LoginController(new LoginView(this), new LoginModel());
            loginController.DisplayView();
        }
    }
}
