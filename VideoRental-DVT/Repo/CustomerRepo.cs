using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoRental_DVT.Data;
using VideoRental_DVT.Models;

namespace VideoRental_DVT.Repo
{
    public class CustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Customer>> GetAllCustomer()
        {
            var customers = await _context.Customers.ToListAsync();
            return customers;
        }
        public async Task<Customer> CreateCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public Customer GetCustomerById(int Id)
        {
            var customer = _context.Customers.FirstOrDefault(d => d.CustomerId.Equals(Id));
            return customer;
        }
        public Customer UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }
        public Customer DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}
