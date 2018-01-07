using System.Collections.Generic;
using CustomerAppDAL;
using CustomerAppEntity;

namespace CustomerAppBLL.Services
{
    public class CustomerService : ICustomerService
    {
        public Customer Create(Customer _customer)
        {
            Customer _newCustomer;
            FakeDB.Customers.Add(_newCustomer = new Customer()
            {
                ID = FakeDB.Id++,
                FirstName = _customer.FirstName,
                LastName = _customer.LastName,
                Address = _customer.Address
            });

            return _newCustomer;
        }

        public Customer DeleteCustomer(int _idCustomer)
        {
            foreach (var _customer in FakeDB.Customers)
            {
                if(_customer.ID == _idCustomer)
                {
                    FakeDB.Customers.Remove(_customer);
                    return _customer;
                }
            }

            return null;
        }

        public List<Customer> GetAllList()
        {
            throw new System.NotImplementedException();
        }

        public Customer GetCustomer(int _idCustomer)
        {
            throw new System.NotImplementedException();
        }

        public Customer UpDateCustomer(Customer _customer)
        {
            throw new System.NotImplementedException();
        }
    }
}