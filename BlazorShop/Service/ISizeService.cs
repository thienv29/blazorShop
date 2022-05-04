using System;
using System.Collections.Generic;
using System.Linq;
using BlazorShop.Entities;
using System.Threading.Tasks;

namespace BlazorShop.Service
{
    public interface ISizeService
    {
        List<Size> GetAllSize();
        
        Size GetSizeFromId(string id);
        Size Add(Size size);
        Size Update(Size size);
        Boolean Delete(string id);

       
    }
}
