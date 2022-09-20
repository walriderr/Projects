using System.Data.Entity;


namespace Project07_v7
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString") { }

        public DbSet<Product> Products { get; set; }
    }
}
