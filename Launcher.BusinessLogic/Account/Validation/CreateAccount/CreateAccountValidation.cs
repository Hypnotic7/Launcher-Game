using System;
using System.Collections.Generic;
using System.Text;
using Launcher.BusinessLogic.Account.Encryption;
using Launcher.BusinessLogic.Account.Validation.Login;
using Launcher.BusinessLogic.RepositoryFactory;
using Launcher.Data.Access.Interface;
using Launcher.Data.Access.Models;
using MongoDB.Bson;

namespace Launcher.BusinessLogic.Account.Validation.CreateAccount
{
    public class CreateAccountValidation : AccountValidation
    {
        public new IDataAccess<AccountEntity> AccountRepository { get; private set; }

        public CreateAccountValidation(IRepositoryFactory<AccountEntity> accountFactory, string connectionString) : base(accountFactory,connectionString)
        {
            AccountRepository = accountFactory.CreateRepository(connectionString, "AccountRepository");
        }

        public CreateAccountValidationStatus CreateAccount(string accountName, string password, string email)
        {
            var createAccountValidationStatus = new CreateAccountValidationStatus {IsValid = false};

            if (accountName.Equals(string.Empty)) return createAccountValidationStatus;
            if (password.Equals(string.Empty)) return createAccountValidationStatus;
            if (email.Equals(string.Empty))return createAccountValidationStatus;

            accountName = accountName.Trim();
            password = password.Trim();
            email = email.Trim();

            try
            {
                AccountRepository.Find(accountName);
                createAccountValidationStatus.IsValid = false;
                return createAccountValidationStatus;
            }
            catch (KeyNotFoundException)
            {
                var accountId = ObjectId.GenerateNewId();
                AccountRepository.Add(new AccountEntity()
                {
                    AccountId = accountId.ToString(),
                    AccountName = accountName,
                    Password = EncrytionUtility.ComputePasswordHashValue(password),
                    Email = email
                });
                createAccountValidationStatus.IsValid = true;
                return createAccountValidationStatus;
            }
        }

    }
}
