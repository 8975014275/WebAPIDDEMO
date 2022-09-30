using WebAPIDDEMO.Models;
using WebAPIDDEMO.Repositories;

namespace WebAPIDDEMO.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepositoty _repo;
        public CustomerService(ICustomerRepositoty repo)
        {
            _repo = repo;
        }
        public int AddCustomer(Customer customer)
        {
            return _repo.AddCustomer(customer);
        }

        public int DeleteCustomer(int? id)
        {
            return (_repo.DeleteCustomer(id));
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }

        public Customer GetCustomerById(int? id)
        {
            return _repo.GetCustomerById(id);
        }

        public int UpdateCustomer(Customer customer)
        {
            return _repo.UpdateCustomer(customer);
        }
        public IEnumerable<Address> GetAddresses()
        {
            return _repo.GetAddresses();
        }
    }
}
