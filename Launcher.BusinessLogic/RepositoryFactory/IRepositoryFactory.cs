using Launcher.Data.Access.Interface;

namespace Launcher.BusinessLogic.RepositoryFactory
{
    public interface IRepositoryFactory<T>
    {
        IDataAccess<T> CreateRepository(string connectionString, string type);
    }
}
