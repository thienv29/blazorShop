using BlazorShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Service
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product Add(Product product);
        Product Update(Product product);
        Boolean Delete(string idproduct);
        Product GetProductFromId(string id);
        Boolean UpdateStatusProduct(string idproduct,int status);
        Boolean IncreaseAmount(string idproduct,int amount);
        Boolean DecreaseAmount(string idproduct,int amount);
    }
}
