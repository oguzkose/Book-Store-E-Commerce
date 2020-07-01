using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStoreECommerce.Data.Entities
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        public string ProductImagePath { get; set; }
        public int ProductId { get; set; }
        public DateTime AddDate { get; set; }

    }
}
