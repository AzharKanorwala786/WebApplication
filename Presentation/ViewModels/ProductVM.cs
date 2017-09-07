﻿using System.Collections.Generic;

namespace Presentation.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public List<CategoryVM> Categories { get; set; }
    }
}