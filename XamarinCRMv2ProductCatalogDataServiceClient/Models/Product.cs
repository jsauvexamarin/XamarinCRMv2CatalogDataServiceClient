using System;

namespace XamarinCRMv2CatalogDataServiceClient.Models
{
    public class Product
    {
        public Product()
        {
            Name = Description = ImageUrl = string.Empty;
            Price = 0;
            CatalogCategory = new Category();
        }

        public string Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public Category CatalogCategory { get; set; }
    }
}

