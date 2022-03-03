using ExampleApi.Net5.Data.Context;
using ExampleApi.Net5.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExampleApi.Net5.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private DbContext dbContext;
        public DbContext DbContext => dbContext ?? (dbContext = new MasterContext());
        public UnitOfWork()
        {

        }
        public void Dispose()
        {
            DbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(DbContext);
        }

        public int SaveChanges()
        {
            try
            {
                var result = DbContext.SaveChanges();
                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
