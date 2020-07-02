using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreECommerce.Models;
using BookStoreECommerce.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace BookStoreECommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service;
        public ProductController(ProductService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var products = _service.GetBooks();
            var model = new List<BookVM>();
            foreach (var item in products)
            {
                model.Add(new BookVM()
                {
                    Id = item.Id,
                    Name = item.Name,
                    BookImages = item.BookImages,
                    AddDate = item.AddDate,
                    BookPages = item.BookPages,
                    BookPublisher  = item.BookPublisher,
                    CategoryId = item.CategoryId,
                    CategoryName = item.CategoryName,
                    DatePublished = item.DatePublished,
                    Description = item.Description,
                    Isbn  = item.Isbn,
                    Price = item.Price,
                    ReviewCount = item.ReviewCount
                });
            }

            return View(model);
        }
    }
}
