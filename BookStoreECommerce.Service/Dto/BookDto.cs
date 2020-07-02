using BookStoreECommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreECommerce.Service.Dto
{
    public class BookDto
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
        public List<BookImagesDto> BookImages{ get; set; }
    }
}
