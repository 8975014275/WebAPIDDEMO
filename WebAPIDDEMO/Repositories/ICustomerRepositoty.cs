using WebAPIDDEMO.Models;

namespace WebAPIDDEMO.Repositories
{
    public interface ICustomerRepositoty
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int? id);
        int AddCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        int DeleteCustomer(int? id);
        IEnumerable<Address> GetAddresses();
    }
}
