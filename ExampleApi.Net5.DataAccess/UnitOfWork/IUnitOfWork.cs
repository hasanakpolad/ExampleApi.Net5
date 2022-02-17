using ExampleApi.Net5.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApi.Net5.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        IRepository<T> GetRepository<T>() where T : class;
    }
}
