using System.Collections.Generic;
using CustomerAppEntity;

namespace CustomerAppDAL
{
    public class FakeDB
    {
        public static int Id = 1;
        public static List<Customer> Customers = new List<Customer>();
    }
}