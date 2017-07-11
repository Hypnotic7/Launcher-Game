using Launcher.BusinessLogic.RepositoryFactory;
using Launcher.Data.Access.Interface;
using Launcher.Data.Access.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Launcher.BusinessLogic.Account.Validation.Logout
{
    public class AccountLogoutValidation
    {
        public IDataAccess<AccountEntity> AccountRepository { get; private set; }

        public AccountLogoutValidation(IRepositoryFactory<AccountEntity> accountFactory, string connectionString)
        {
            AccountRepository = accountFactory.CreateRepository(connectionString, "AccountRepository");
        }

        public AccountLogoutStatus Logout(string accountName)
        {
            AccountLogoutStatus _accountLogoutStatus = new AccountLogoutStatus { LoggedOut = false };
            string _accountName;

            _accountName = accountName.Trim();

            var _account = AccountRepository.Find(_accountName);

            if (_account.Equals(null)) return _accountLogoutStatus;

            _account.IsLoggedIn = false;

            AccountRepository.Modify(_account);

            _accountLogoutStatus.LoggedOut = true;

            return _accountLogoutStatus;
        }



    }
}
