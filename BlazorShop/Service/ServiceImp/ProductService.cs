using BlazorShop.Data;
using BlazorShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Service
{
    public class ProductService : IProductService
    {
        private ApplicationDbContext _applicationDbContext;
        public ProductService(ApplicationDbContext appLicationDbContext)
        {
            _applicationDbContext = appLicationDbContext;
        }

        public Product Add(Product product)
        {
            try
            {
                String guid = System.Guid.NewGuid().ToString();
                product.Id = guid;
                _applicationDbContext.Products.Add(product);
                _applicationDbContext.SaveChanges();
                return product;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Delete(string idproduct)
        {
            try
            {
                var product = _applicationDbContext.Products.FirstOrDefault(x => x.Id == idproduct);
                _applicationDbContext.Products.Remove(product);
                _applicationDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Product> GetAllProducts()
        {
            var data = _applicationDbContext.Products.Include(x => x.Category).ToList();
            return data;
        }

        public Product GetProductFromId(string id)
        {
            var data = _applicationDbContext.Products
                .Where(x => x.Id == id)
                .Include(x => x.Sizes)
                .Include(x => x.ColorDBs)
                .Include(x => x.Category).Single();
            return data;
            
        }

        public Product Update(Product product)
        {
            try
            {
                _applicationDbContext.Products.Update(product);
                _applicationDbContext.SaveChanges();
                return product;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool IncreaseAmount(string idproduct, int amount)
        {
            try
            {
                var product = _applicationDbContext.Products.FirstOrDefault(x => x.Id == idproduct);
                product.Amount += amount;
                _applicationDbContext.Products.Remove(product);
                _applicationDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DecreaseAmount(string idproduct, int amount)
        {
            try
            {
                var product = _applicationDbContext.Products.FirstOrDefault(x => x.Id == idproduct);
                product.Amount -= amount;
                _applicationDbContext.Products.Remove(product);
                _applicationDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateStatusProduct(string idproduct, int status)
        {
            try
            {
                var product = _applicationDbContext.Products.FirstOrDefault(x => x.Id == idproduct);
                product.Status = status;
                _applicationDbContext.Products.Remove(product);
                _applicationDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
