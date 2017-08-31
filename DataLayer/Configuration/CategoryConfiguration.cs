namespace DataAccess.Configuration
{
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            //Table Name
            ToTable("testcategory");
            //Primary Key
            HasKey(x => x.Id);

            //Column Mapping
            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}
