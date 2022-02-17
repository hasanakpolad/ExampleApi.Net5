using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ExampleApi.Net5.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<T>();
        }
        public void Add(T model)
        {
            _dbSet.Add(model);
        }

        public void Delete(T model)
        {
            _dbContext.Entry(model).State = EntityState.Deleted;
            _dbSet.Attach(model);
            _dbSet.Remove(model);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            var data = _dbSet.Where(expression);
            return data.FirstOrDefault();
        }

        public List<T> GetAll()
        {
            var data = _dbSet;
            return data.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T model)
        {
            _dbSet.Attach(model);
            _dbContext.Entry(model).State = EntityState.Modified;
        }
    }
}
