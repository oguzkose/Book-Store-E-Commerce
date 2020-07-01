using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreECommerce.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime AddDate { get; set; }
        public int Quantity { get; set; }

    }
}
