﻿using System;

namespace XamarinCRMv2CatalogDataServiceClient.Models
{
    public class Category
    {
        public Category()
        {
            Name = Description = ImageUrl = ParentCategoryId = string.Empty;
        }

        public string Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ParentCategoryId { get; set; }
        public bool HasSubCategories { get; set;}
    }
}

