namespace Pronia_HW.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductPhoto> productphotos { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
