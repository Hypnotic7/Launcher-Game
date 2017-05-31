using Launcher.Data.Access.Models;

namespace Launcher.BusinessLogic.Account.Validation.Login
{
    public class AccountValidationStatus
    {
        public bool IsValid { get; set; }
        public AccountEntity Account { get; set; }
    }
}
