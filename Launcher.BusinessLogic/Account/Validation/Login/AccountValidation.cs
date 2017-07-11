using System;
using Launcher.BusinessLogic.Account.Encryption;
using Launcher.BusinessLogic.RepositoryFactory;
using Launcher.Data.Access.Interface;
using Launcher.Data.Access.Models;

namespace Launcher.BusinessLogic.Account.Validation.Login
{
    public class AccountValidation
    {
        public IDataAccess<AccountEntity> AccountRepository { get; private set; }

        public AccountValidation(IRepositoryFactory<AccountEntity> accountFactory, string connectionString)
        {
            AccountRepository = accountFactory.CreateRepository(connectionString,"AccountRepository");
        }

        public AccountValidationStatus ValidateAccount(string accountName,string password)
        {
            AccountValidationStatus accountValidationStatus = new AccountValidationStatus {IsValid = false};

            if (accountName.Equals(string.Empty)) return accountValidationStatus;
            if (password.Equals(string.Empty)) return accountValidationStatus;

            accountName = accountName.Trim();
            password = password.Trim();

            var account = AccountRepository.Find(accountName);

            if (account.Equals(null)) return accountValidationStatus;

            accountValidationStatus.IsValid = account.Password.Equals(EncrytionUtility.ComputePasswordHashValue(password));

            if (accountValidationStatus.IsValid)
            {
                account.IsLoggedIn = true;
                AccountRepository.Modify(account);
            }
            accountValidationStatus.Account = account;
            return accountValidationStatus;
        }
       
    }
}
