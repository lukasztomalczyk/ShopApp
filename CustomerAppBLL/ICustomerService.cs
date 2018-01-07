using System.Collections.Generic;
using CustomerAppEntity;

namespace CustomerAppBLL
{
    public interface ICustomerService
    {
         Customer Create (Customer _customer);
         List<Customer> GetAllList();
         Customer GetCustomer(int _idCustomer);
         Customer UpDateCustomer(Customer _customer);
         Customer DeleteCustomer(int _idCustomer);
    }
}