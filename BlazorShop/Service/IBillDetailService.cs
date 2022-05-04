using BlazorShop.Entities;
using System.Collections.Generic;

namespace BlazorShop.Service
{
    public interface IBillDetailService
    {
        public IEnumerable<BillDetail> GetBillDetailFromId(string BillId);
        public IEnumerable<BillDetail> GetListResultFromIdProduct(string IdProduct);
    }
}
