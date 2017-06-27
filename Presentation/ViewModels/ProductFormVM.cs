namespace Presentation.ViewModels
{
    using System.Collections.Generic;
    using System.Web;

    public class ProductFormVM
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Description { get; set; } 
        public decimal Price { get; set; } 
        public string Image { get; set; }
        public HttpPostedFileBase File { get; set; }
        public int CategoryId { get; set; } 
        public List<CategoryVM> Categories { get; set; }
    }
}