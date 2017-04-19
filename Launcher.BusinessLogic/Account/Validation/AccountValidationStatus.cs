using Launcher.Data.Access.Models;

namespace Launcher.BusinessLogic.Account.Validation
{
    public class AccountValidationStatus
    {
        public bool IsValid { get; set; }
        public AccountEntity Account { get; set; }
    }
}
