using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class GenericRepository<T> : IRepository<T> where T : IEntity
    {
        private List<T> _entities;
        public void Add(T item)
        {
            _entities.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            foreach (T item in _entities) {
                if (item.Id == id) {
                    return item;
                }
            }
            return default(T);
        }

        public void Remove(T item)
        {
            _entities.Remove(item);
        }

        public void Save()
        {
            Console.WriteLine("saved");
        }
    }
}
