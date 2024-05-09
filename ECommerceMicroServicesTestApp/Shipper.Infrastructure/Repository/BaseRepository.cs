using Microsoft.EntityFrameworkCore;
using Shipper.ApplicationCore.RepositoryContract;
using Shipper.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipper.Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        protected readonly ShipperDbContext _context;
        public BaseRepositoryAsync(ShipperDbContext c)
        {
            _context = c;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var i = await GetByIdAsync(id);
            if (i != null)
            {
                _context.Set<T>().Remove(i);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllByFilterAsync(Func<T, bool> condition)
        {
            return _context.Set<T>().Where(condition).ToList();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public T GetFirstByFilterAsync(Func<T, bool> condition)
        {
            return _context.Set<T>().FirstOrDefault(condition);
        }

        public async Task<int> InsertAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _context.Set<T>().Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
