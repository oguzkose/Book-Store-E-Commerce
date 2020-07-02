using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStoreECommerce.Data.Entities
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public float Point { get; set; }
        public DateTime AddDate { get; set; }

    }
}
