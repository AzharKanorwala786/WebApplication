namespace DataLayer.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using DTO;

    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("testproduct");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal").IsRequired().HasPrecision(18, 4);
            Property(x => x.Image).HasColumnName(@"Image").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Category).WithMany(b => b.Products).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK__products__Catego__1273C1CD
        }
    }
}
