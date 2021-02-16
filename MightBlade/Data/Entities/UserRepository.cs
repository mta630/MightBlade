using MightBlade.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MightBlade.Data.Entities
{
    public class UserRepository
    {
        private readonly MBContext _context;
        public UserRepository(MBContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<User>>> GetUsersAsync()
        {
            IQueryable<User> query = _context.Users;

            return await query.ToListAsync();
        }

        public async Task<ActionResult<User>> GetCustomerAsync(Guid id)
        {
            IQueryable<User> query = _context.Users;

            return await query
                .FirstOrDefaultAsync(c => c.Id == id);

        }

        // public async Task<ActionResult<Customer>> GetCustomerAsync(string customerName)
        // {
        //     return await _context.Customers.FirstOrDefaultAsync(c => c.Name == customerName);
        // }

        // public void Add(Customer customer)
        // {
        //     _context.Add(customer);
        // }

        // public void Delete(Customer customer)
        // {
        //     _context.Remove(customer);
        // }

        // public async Task<bool> SaveChangesAsync()
        // {
        //     return (await _context.SaveChangesAsync()) > 0;
        // }
    }
}
