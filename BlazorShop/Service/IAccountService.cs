using System.Collections;
using System.Collections.Generic;
using BlazorShop.Entities;

namespace BlazorShop.Service
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccountCustomer();
        IEnumerable<Account> GetAllAccountEmployee();

        Account GetAccount(string id);

        void UpdateStatus(string Id, int status);
        void DeleteAccount(Account account);

        Account GetAccountFromAccountId(string AccountId);
    }
}
