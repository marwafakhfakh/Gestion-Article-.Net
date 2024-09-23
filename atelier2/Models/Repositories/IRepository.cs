namespace atelier2.Models.Repositories
{
    public interface IRepository<T>
    {
        T Get(int Id);
        IEnumerable<T> GetAll();
        T FindByID(int id);
        T Add(T t);
        T Update(T t);
        T Delete(int Id);
    }
}
