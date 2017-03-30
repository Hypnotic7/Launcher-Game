using System;
using BuisnessLogic.Account.Validation;
using DataAccess;
using DataAccess.Interface;

namespace BuisnessLogic
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

            if (!accountName.Equals(String.Empty) || password.Equals(String.Empty))
            {
                var account = AccountRepository.Find(accountName);
                if (!account.Equals(null))
                {
                    accountValidationStatus.IsValid = account.Password.Equals(password);
                    accountValidationStatus.Account = account;
                }
            }
            return accountValidationStatus;
        }
    }
}
