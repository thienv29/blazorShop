using BlazorShop.Data;
using BlazorShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Service.ServiceImp
{
    public class CustomerService : ICustomerService
    {
        private ApplicationDbContext _applicationDbContext;
        public CustomerService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public Customer GetCustomerFromIdAccount(string id)
        {
            return _applicationDbContext.Users.FirstOrDefault(x => x.AccountId == id);
        }

        public Customer GetCustomerFromIdUser(string id)
        {
            return _applicationDbContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
