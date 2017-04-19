namespace Launcher.Data.Access.Interface
{
    public interface IDataAccess<T>
    {
        string CollectionName { get; }
        void Add(T entity);
        void Remove(T entity);
        void Modify(T entity);

        T Find(string id);

    }
}
