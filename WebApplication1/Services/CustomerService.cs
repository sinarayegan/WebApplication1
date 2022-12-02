using System.Collections.Generic;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customerList = new List<Customer>();
        public int AddCustomer(Customer customer)
        {
            customer.Id = customerList.Count + 1;
            customerList.Add(customer);
            return customer.Id;
        }

        public List<Customer> GetAllCustomers()
        {
            return customerList;
        }
    }
}
