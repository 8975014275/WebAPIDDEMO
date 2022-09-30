using WebAPIDDEMO.Models;

namespace WebAPIDDEMO.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int? id);
        int AddCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        int DeleteCustomer(int? id);
        public IEnumerable<Address> GetAddresses();
    }
}
