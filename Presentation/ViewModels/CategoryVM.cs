using System.Collections.Generic;

namespace Presentation.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 50)

        // Reverse navigation
        public virtual ICollection<ProductVM> Products { get; set; } 

        public CategoryVM()
        {
            Products = new List<ProductVM>();
        }
    }
}