using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ICustomerService
    {
        int AddCustomer(Customer customer);
        List<Customer> GetAllCustomers();
    }
}