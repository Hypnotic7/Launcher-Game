namespace DataAccess.Interface
{
    public interface IRepositoryFactory<T>
    {
        IDataAccess<T> CreateRepository(string connectionString, string type);
    }
}
