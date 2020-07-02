using BookStoreECommerce.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreECommerce.Models
{
    public class BookVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Description { get; set; }
        public int BookPages { get; set; }
        public string BookPublisher { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime AddDate { get; set; }
        public decimal Price { get; set; }
        public int? ReviewCount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<BookImagesDto> BookImages { get; set; }
    }
}
