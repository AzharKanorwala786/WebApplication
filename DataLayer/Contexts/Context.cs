namespace DataLayer.Contexts
{
    using System.Data.Entity;
    using Configuration;
    using DTO;


    public class Context : DbContext
    {
        public Context()
            : base("Name=defaultCS")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}
