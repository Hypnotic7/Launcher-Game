using BuisnessLogic;
using BuisnessLogic.Factory;
using DataAccess;
using LauncherDisplay.Controller.Interfaces;
using LauncherDisplay.Model;
using LauncherDisplay.View;

namespace LauncherDisplay.Controller
{
    public class LoginController : IDisplayView
    {
        public LoginView LoginWindow{ get; set; }
        public LoginModel Account { get; set; }
        public AccountEntity AccountEntity { get; set; }
        public LoginController(LoginView window, LoginModel account)
        {
            LoginWindow = window;
            Account = account;
        }

        public bool ProcessValidation()
        {
            AccountValidation accountValidation = new AccountValidation(new RepositoryFactory<AccountEntity>(),
                "mongodb://192.168.99.100:32768/local");
            var accountValidationStatus = accountValidation.ValidateAccount(Account.AccountName, Account.Password);
            if (accountValidationStatus.IsValid)
                AccountEntity = accountValidationStatus.Account;

            return accountValidationStatus.IsValid;
        }

        public void DisplayView()
        {
            LoginWindow.Display();
        }
    }
}
