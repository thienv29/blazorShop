using BlazorShop.Entities;
using System.Collections.Generic;
using BlazorShop.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Service.ServiceImp
{
    public class VoucherService : IVoucherService
    {
        private ApplicationDbContext _appLicationDbContext;
        public VoucherService(ApplicationDbContext appLicationDbContext)
        {
            _appLicationDbContext = appLicationDbContext;
        }
        public IEnumerable<Voucher> getAllVouchers()
        {
            return _appLicationDbContext.Vouchers.ToList();
        }
    }
}
