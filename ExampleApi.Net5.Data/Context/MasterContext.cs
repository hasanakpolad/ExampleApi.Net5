using ExampleApi.Net5.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleApi.Net5.Data.Context
{
    public class MasterContext : DbContext
    {
        public MasterContext(DbContextOptions<MasterContext> optionsBuilder) : base(optionsBuilder)
        {

        }
        public MasterContext()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("Server=localhost;Database=newDb;Uid=root;Pwd=root;");
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            //modelBuilder.Entity<Use>
            base.OnModelCreating(modelBuilder);
        }
    }
}
