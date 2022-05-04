using BlazorShop.Data;
using BlazorShop.Entities;
using System.Collections.Generic;
using System.Linq;
namespace BlazorShop.Service.ServiceImp
{
    public class SizeColorProductService : ISizeColorProductService
    {
        private ApplicationDbContext _applicationDbContext;
        public SizeColorProductService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void DeleteFromIdProduct(string idproduct)
        {
            IEnumerable<SizeColorProduct> _sizecolorproduct = GetResultFromIdProduct(idproduct);
            int length = _sizecolorproduct.Count();
            foreach (SizeColorProduct item in _sizecolorproduct)
            {
                _applicationDbContext.SizeColorProducts.Remove(item);
            }
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<SizeColorProduct> GetResultFromIdProduct(string IdProduct)
        {
            return _applicationDbContext.SizeColorProducts.Where(x => x.ProductId == IdProduct);
        }
    }
}
