using EntityFramework.Core.Interfaces;
using EntityFramework.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Infrastructure.Repositories;

public class BaseRepository<T> :IRepository<T> where T: class
{
    private DbContextDemo _dbContextDemo = new DbContextDemo();
    
    public int Insert(T obj)
    {
        _dbContextDemo.Set<T>().Add(obj);
        _dbContextDemo.SaveChanges();
        return 1;
    }

    public int DeleteByID(int id)
    {
        var entity = _dbContextDemo.Set<T>().Find(id);
        if (entity != null)
        {
            _dbContextDemo.Set<T>().Remove(entity);
            _dbContextDemo.SaveChanges();
            return 1;
        }
        return 0;
    }

    public int Update(T obj)
    {
        _dbContextDemo.Entry(obj).State = EntityState.Modified;
        _dbContextDemo.SaveChanges();
        return 1;
    }

    public IEnumerable<T> GetAll()
    {
        return _dbContextDemo.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _dbContextDemo.Set<T>().Find(id);
    }
}