namespace DataAccess.Configuration
{
    using Entities;
    using System.Data.Entity.ModelConfiguration;

    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            //Table Name
            ToTable("testproduct");
            //Primary Key
            HasKey(x => x.Id);

            //Column Mapping
            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal").IsRequired().HasPrecision(18, 4);
            Property(x => x.Image).HasColumnName(@"Image").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Category).WithMany().HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK__products__Catego__1273C1CD
        }
    }
}
