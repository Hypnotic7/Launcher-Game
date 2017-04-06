using System;
using DataAccess.Constants;
using MongoDB.Driver;

namespace DataAccess
{
    public class AccountRepositoryMongo : MongoRepository, IDataAccess<AccountEntity>
    {
        public string CollectionName => "Accounts";
        public static readonly Func<string, AccountRepositoryMongo> CreateAccountRepository = c => { return new AccountRepositoryMongo(new MongoClient(c)); };

        private AccountRepositoryMongo(IMongoClient mongoClient) : base(mongoClient)
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
            var account = collection.Find(f => f.AccountName.Equals(accountName)).FirstOrDefault();
            return new AccountEntity() { AccountID = account.AccountID, AccountName = account.AccountName, Password = account.Password, Email = account.Email};
        }

        
    }
}
