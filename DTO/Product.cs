namespace DTO
{
    public class Product
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public string Description { get; set; } // Description (length: 100)
        public decimal Price { get; set; } // Price
        public string Image { get; set; } // Image
        public int? CategoryId { get; set; } // CategoryId

        // Foreign keys

        /// <summary>
        /// Parent Category pointed by [products].([CategoryId]) (FK__products__Catego__1273C1CD)
        /// </summary>
        public virtual Category Category { get; set; } // FK__products__Catego__1273C1CD
    }
}
