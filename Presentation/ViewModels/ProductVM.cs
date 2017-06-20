namespace Presentation.ViewModels
{

    public class ProductVM
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public string Description { get; set; } // Description (length: 100)
        public decimal Price { get; set; } // Price
        public string Image { get; set; } // Image
        public int? CategoryId { get; set; } // CategoryId

        // Foreign keys
        public virtual CategoryVM Category { get; set; }
    }
}