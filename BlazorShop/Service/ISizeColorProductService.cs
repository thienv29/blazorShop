using BlazorShop.Entities;
using System.Collections.Generic;

namespace BlazorShop.Service
{
    public interface ISizeColorProductService
    {
        IEnumerable<SizeColorProduct> GetResultFromIdProduct(string IdProduct);
        void DeleteFromIdProduct(string idproduct);
    }
}
