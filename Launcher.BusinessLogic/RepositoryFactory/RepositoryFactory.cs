using System;
using Launcher.Data.Access.Interface;
using Launcher.Data.Access.Repository.MongoRepository;

namespace Launcher.BusinessLogic.RepositoryFactory
{
    public class RepositoryFactory<T> : IRepositoryFactory<T>
    {
        public IDataAccess<T> CreateRepository(string connectionString, string type)
        {
            switch (type)
            {
                case "AccountRepository":
                    return (IDataAccess<T>)AccountRepositoryMongo.CreateAccountRepository(connectionString);
                default:
                    throw new ArgumentException(type + " Could not be found");

            }
        }
    }
}
