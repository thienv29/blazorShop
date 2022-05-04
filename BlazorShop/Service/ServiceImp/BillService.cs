using BlazorShop.Data;
using BlazorShop.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorShop.Service.ServiceImp
{
    public class BillService : IBillService
    {
        private ApplicationDbContext _appLicationDbContext;
        public BillService(ApplicationDbContext appLicationDbContext)
        {
            _appLicationDbContext = appLicationDbContext;
        }
        public IEnumerable<Bill> getAllBills()
        {
            return _appLicationDbContext.Bills.ToList();
        }
        public Bill GetBill(string id)
        {
            return _appLicationDbContext.Bills.FirstOrDefault(x => x.Id == id);
        }

        public Bill GetBillFromId(string id)
        {
            return _appLicationDbContext.Bills.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateStatus(string IdBill, int Status)
        {

            /*var bill = new Bill()
            {
                Id = IdBill,
                StatusBill = Status
            };
            _appLicationDbContext.Bills.Attach(bill);
            _appLicationDbContext.Entry(bill).Property(x => x.StatusBill).IsModified = true;
            _appLicationDbContext.SaveChanges();*/
            Bill bill = GetBill(IdBill);
            if (bill != null)
            {
                bill.StatusBill = Status;
                _appLicationDbContext.SaveChanges();
            }


        }
    }
}
