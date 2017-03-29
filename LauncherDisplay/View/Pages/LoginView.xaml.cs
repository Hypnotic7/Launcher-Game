using System.Windows;
using LauncherDisplay.Model;
using System.Windows.Controls;
using LauncherDisplay.Controller;
using LauncherDisplay.View.Interfaces;

namespace LauncherDisplay.View
{
    public partial class LoginView : Page, IDisplay
    {
        private MainWindow MainWindow { get; set; }
        public LoginModel LoginModel { get; set; }
        public LoginView(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            LoginModel = new LoginModel();
            InitializeComponent();
            LoginGrid.DataContext = LoginModel;
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginController controller = new LoginController(this, LoginModel);
            var isValid = controller.ProcessValidation();
            if (!isValid)
            {
                ErrorLbl.Content = LauncherConstants.LoginError;
                ErrorLbl.Visibility = Visibility.Visible;
            }
            else
            {
                LauncherModel launcherModel = new LauncherModel();
                launcherModel.AccountModel.AccountID = controller.AccountEntity.AccountID;
                launcherModel.AccountModel.AccountName = controller.AccountEntity.AccountName;
                launcherModel.AccountModel.Password = controller.AccountEntity.Password;
                launcherModel.AccountModel.Email = controller.AccountEntity.Email;
                LauncherController launcherController = new LauncherController(MainWindow,launcherModel);
                launcherController.DisplayView();
            }
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountController createAccountController = new CreateAccountController(MainWindow,new AccountModel());
            createAccountController.DisplayView();
        }

        public void Display()
        {
            MainWindow.MainFrame.NavigationService.Navigate(new LoginView(MainWindow));
        }
    }
}
