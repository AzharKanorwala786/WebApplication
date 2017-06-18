namespace DTO
{
    using System.Collections.Generic;
    public class Category
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Products where [products].[CategoryId] point to this entity (FK__products__Catego__1273C1CD)
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } // products.FK__products__Catego__1273C1CD

        public Category()
        {
            Products = new List<Product>();
        }
    }
}