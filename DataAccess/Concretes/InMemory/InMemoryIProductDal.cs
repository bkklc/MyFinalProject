using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryIProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryIProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1,CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 20},
                new Product {ProductId = 2,CategoryId = 1, ProductName = "Tabak", UnitPrice = 150, UnitsInStock = 17},
                new Product {ProductId = 3,CategoryId = 2, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 10},
                new Product {ProductId = 4,CategoryId = 3, ProductName = "Telefon", UnitPrice = 358, UnitsInStock = 5},
                new Product {ProductId = 5,CategoryId = 4, ProductName = "Fare", UnitPrice = 45, UnitsInStock = 20},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query
            // Lambda - =>

            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün idi sine sahip olan ürün idsini bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
