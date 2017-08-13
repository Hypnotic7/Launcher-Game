﻿using System;
using System.Collections.Generic;
using Launcher.Data.Access.Constants;
using Launcher.Data.Access.Interface;
using Launcher.Data.Access.Models;
using MongoDB.Driver;

namespace Launcher.Data.Access.Repository.MongoRepository
{
    public class AccountRepositoryMongo : MongoRepository, IDataAccess<AccountEntity>
    {
        public string CollectionName => "Accounts";
        public static readonly Func<string, AccountRepositoryMongo> CreateAccountRepository = c => new AccountRepositoryMongo(new MongoClient(c));

        private AccountRepositoryMongo(IMongoClient mongoClient) : base(mongoClient)
        {
            
        }
        
        public  void Add(AccountEntity entity)
        {
            try
            {
                var collection = Connect(DataAccessConstants.DatabaseName).GetCollection<AccountEntity>(CollectionName);
                collection.InsertOne(entity);
            }
            catch (Exception e)
            {
                throw new  NotImplementedException();
            }
        }
        public void Remove(AccountEntity entity)
        {
            
        }

        public void Modify(AccountEntity entity)
        {
            try
            {
                var collection = Connect(DataAccessConstants.DatabaseName).GetCollection<AccountEntity>(CollectionName);
                collection.ReplaceOne(f => f.AccountName.Equals(entity.AccountName), entity);
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            
        }

       public AccountEntity Find(string accountName)
        {
            try
            {
                var collection = Connect(DataAccessConstants.DatabaseName).GetCollection<AccountEntity>(CollectionName);
                var account = collection.Find(f => f.AccountName.Equals(accountName)).FirstOrDefault();

                if (account != null)
                    return new AccountEntity()
                    {
                        AccountId = account.AccountId,
                        AccountName = account.AccountName,
                        Password = account.Password,
                        Email = account.Email,
                        IsLoggedIn = account.IsLoggedIn,
                        LastLoginDate = account.LastLoginDate
                    };
            }
            catch (Exception e)
            {
                throw new KeyNotFoundException($"Account Name not found: {accountName}");
            }

            throw new KeyNotFoundException($"Account Name not found: {accountName}");
        }
    }
}
