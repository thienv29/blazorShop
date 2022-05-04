using BlazorShop.Data;
using BlazorShop.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BlazorShop.Service.ServiceImp
{
    public class EmployeeService : IEmployeeService
    {
        private ApplicationDbContext _appLicationDbContext;
        public EmployeeService(ApplicationDbContext appLicationDbContext)
        {
            _appLicationDbContext = appLicationDbContext;
        }

        public void DeleteEmployee(Employee employee)
        {
            _appLicationDbContext.Remove(employee);
            _appLicationDbContext.SaveChanges();
        }

        public IEnumerable<Employee> getAllEmployees()
        {
            return _appLicationDbContext.Employee.ToList();
        }
    }
}
