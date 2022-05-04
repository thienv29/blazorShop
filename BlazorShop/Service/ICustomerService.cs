using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorShop.Entities;

namespace BlazorShop.Service
{
    public interface ICustomerService
    {
        Customer GetCustomerFromIdUser(string id);
        Customer GetCustomerFromIdAccount(string id);

    }
}
