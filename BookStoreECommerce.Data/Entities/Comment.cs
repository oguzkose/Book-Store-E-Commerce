using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStoreECommerce.Data.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Commentate { get; set; }
        public DateTime AddDate { get; set; }
    }
}
