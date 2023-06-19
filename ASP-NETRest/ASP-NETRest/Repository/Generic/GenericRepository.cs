using ASP_NETRest.Model.Base;
using ASP_NETRest.Model.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ASP_NETRest.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySQLContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(MySQLContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }

        public T Create(T item)
        {
            try
            {
                _dbSet.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void Delete(long id)
        {
            var result = _dbSet.SingleOrDefault(p => p.Id == id);
            if (result != null)
            {
                try
                {
                    _dbSet.Remove(result);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _dbSet.Any(p => p.Id == id);
        }

        public List<T> FindAll()
        {
            return _dbSet.ToList(); 
        }

        public T FindByID(long id)
        {
            return _dbSet.SingleOrDefault(p => (p.Id.Equals(id)));
        }

        public T Update(T item)
        {
            var result = _dbSet.SingleOrDefault(p => p.Id == item.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
            else return null;
        }
    }
}
