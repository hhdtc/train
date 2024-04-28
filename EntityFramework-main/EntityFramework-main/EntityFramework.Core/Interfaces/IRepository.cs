namespace EntityFramework.Core.Interfaces;

public interface IRepository<T> where T: class
{
    int Insert(T obj);
    int DeleteByID(int id);
    int Update(T obj);
    IEnumerable<T> GetAll();
    T GetById(int id);
}