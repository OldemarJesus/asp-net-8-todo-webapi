using backend.Domain;

namespace backend.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> List();
        bool Create(T item);
        bool Delete(string id);
        T? Get(string id);
        bool SaveChanges(Note item);
    }
}
