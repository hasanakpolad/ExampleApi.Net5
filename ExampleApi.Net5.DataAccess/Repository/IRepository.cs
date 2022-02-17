using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExampleApi.Net5.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> expression);
        List<T> GetAll();
        T GetById(int id);
        void Add(T model);
        void Update(T model);
        void Delete(T model);
    }
}
