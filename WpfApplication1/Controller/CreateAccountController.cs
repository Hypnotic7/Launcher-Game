using LauncherDisplay.Controller.Interfaces;
using LauncherDisplay.Model;
using LauncherDisplay.View;

namespace LauncherDisplay.Controller
{
    public class CreateAccountController : IDisplayView
    {
        private MainWindow MainWindow { get; set; }
        private AccountModel AccountModel { get; set; }
        public CreateAccountController(MainWindow mainWindow, AccountModel accountModel)
        {
            MainWindow = mainWindow;
            AccountModel = accountModel;
        }

        public void DisplayView()
        {
            CreateAccountView createAccountView = new CreateAccountView(MainWindow);
            createAccountView.Display();
        }
    }
}
