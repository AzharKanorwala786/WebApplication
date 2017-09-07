namespace Entities
{
    public class Product
    {
        /// <summary>
        /// Id (Primary key)
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// Name (length: 50)
        /// </summary>
        public string Name { get; set; } 
        /// <summary>
        /// Description (length: 100)
        /// </summary>
        public string Description { get; set; } 
        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; } 
        /// <summary>
        ///  Image
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// CategoryId  
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Category
        /// </summary>
        public virtual Category Category { get; set; }
    }
}
