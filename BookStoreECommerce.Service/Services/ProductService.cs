using BookStoreECommerce.Data.Context;
using BookStoreECommerce.Data.Entities;
using BookStoreECommerce.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BookStoreECommerce.Service.Services
{
    public class ProductService
    {
        #region Injection
        private readonly BookEcommerceDbContext _context;
        public ProductService(BookEcommerceDbContext context)
        {
            _context = context;
        } 
        #endregion

        #region Kitap Listesi
        public List<BookDto> GetBooks()
        {
            var entities = _context.Product.Join(_context.Category,
                product => product.CategoryId,
                category => category.Id, 
                (product, category) => new BookDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    BookPages = product.BookPages,
                    BookPublisher = product.BookPublisher,
                    AddDate = product.AddDate,
                    CategoryId = product.CategoryId,
                    DatePublished = product.DatePublished,
                    Description = product.Description,
                    Isbn = product.Isbn,
                    Price = product.Price,
                    ReviewCount = product.ReviewCount,
                    CategoryName = category.Name
                }).ToList();

            foreach (var item in entities)
            {
                var Images = GetImages(item.Id);
                item.BookImages = Images;
            }
            return entities;
        }
        #endregion

        #region Kitap Resimleri
        private List<BookImagesDto> GetImages(int productId)
        {
            return _context.Product.Join(_context.ProductImage,
                product => product.Id,
                productImage => productImage.ProductId,
                (product, productImage) => new { product.Id, productImage }).Where(query => query.productImage.ProductId == productId).Select(result => new BookImagesDto
                {
                    Id = result.productImage.Id,
                    ImagePath = result.productImage.ProductImagePath,
                    ProductId = result.productImage.ProductId
                }).ToList();
        } 
        #endregion
    }
}
