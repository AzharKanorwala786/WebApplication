namespace DataAccess
{
    using Configuration;
    using Entities;
    using System.Data.Entity;


    public class Context : DbContext
    {
        public Context()
            : base("Name=defaultCS")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        //Table Names
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }
    }
}
