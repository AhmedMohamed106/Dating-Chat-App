using DatingChat.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatingChat.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingChat.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        internal DbSet<T> dbset;
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            dbset = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbset;
            query = query.Where(filter);
            if (!(string.IsNullOrEmpty(includeProperties)))
            {
                foreach (var includeprop in includeProperties.Split(new char[] { ',' }
                , StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeprop);
                }

            }

            return query.FirstOrDefault();

        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = dbset;
            if (!(string.IsNullOrEmpty(includeProperties)))
            {
                foreach (var includeprop in includeProperties.Split(new char[] { ',' }
                , StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeprop);
                }

            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbset.Remove(entity);
        }

   
    }
}
