using WebAPIDDEMO.Entities;
using WebAPIDDEMO.Models;

namespace WebAPIDDEMO.Repositories
{
    public class CustomerRepository: ICustomerRepositoty
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            int result = _context.SaveChanges();
            return result;
        }

        public int DeleteCustomer(int? id)
        {
            int res = 0;
            Customer cst = _context.Customers.Where(x => x.Id == id).FirstOrDefault();
            if (cst != null)
            {
                _context.Customers.Remove(cst);
                res = _context.SaveChanges();
                return res;
            }
            else
            {
                return res;
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public IEnumerable<Address> GetAddresses()
        {
            return _context.Addresses.ToList();
        }

        public Customer GetCustomerById(int? id)
        {
            Customer cst = _context.Customers.Find(id);
            return cst;
        }

        public int UpdateCustomer(Customer customer)
        {

            int res = 0;
            Customer cst = _context.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();
            if (cst != null)
            {
                cst.Name = customer.Name;
                cst.Email = customer.Email;
                cst.Contact = customer.Contact;
                cst.Address = customer.Address;
                cst.Password= customer.Password;
                res = _context.SaveChanges();
                return res;
            }
            else
            {
                return res;
            }
        }
    }
}
