using BlazorShop.Entities;
using System.Collections.Generic;

namespace BlazorShop.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> getAllEmployees();

        void DeleteEmployee(Employee employee);

    }
}
