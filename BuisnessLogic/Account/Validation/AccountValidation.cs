using System;
using System.Security.Cryptography;
using System.Text;
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
                    accountValidationStatus.IsValid = account.Password.Equals(ComputePasswordHashValue(password));
                    accountValidationStatus.Account = account;
                }
            }
            return accountValidationStatus;
        }

        private string ComputePasswordHashValue(string password)
        {
            var hasBytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder =  new StringBuilder();

            for (var i = 0; i < hasBytes.Length; i++)
            {
                stringBuilder.Append(hasBytes[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
