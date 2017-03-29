﻿using System;
using DataAccess.Constants;
using MongoDB.Driver;

namespace DataAccess
{
    public class AccountRepository : MongoRepository, IDataAccess<AccountEntity>
    {
        public string CollectionName => "Somestring";
        public static readonly Func<string, AccountRepository> CreateAccountRepository = c => { return new AccountRepository(new MongoClient()); };

        private AccountRepository(IMongoClient mongoClient) : base(mongoClient)
        {
            
        }

        
        public void Add(AccountEntity entity)
        {
            
        }
        public void Remove(AccountEntity entity)
        {
            
        }

        public void Modify(AccountEntity entity)
        {
            
        }

        public AccountEntity Find(string accountName)
        {
            var collection = this.Connect(DataAccessConstants.DatabaseName).GetCollection<AccountEntity>(CollectionName);
            return collection.Find(f => f.AccountName.Equals(accountName)).FirstOrDefault();
        }

        
    }
}
