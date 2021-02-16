using MightBlade.Data;
using MightBlade.Data.Entities;
using MightBlade.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MightBlade.Services
{
    public class UserService
    {
        private readonly UserRepository _repository;
        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult<IEnumerable<User>>> GetUsersAsync(bool includeLots = false, bool includeLotActions = true, bool includeHedgeContracts = true, bool includeInactive = false)
        {

            return await _repository.GetUsersAsync();
        }

        public async Task<ActionResult<User>> GetUserAsync(Guid id)
        {
            return await _repository.GetCustomerAsync(id);
        }

        // public async Task<ActionResult<Customer>> GetCustomerAsync(CustomerModel model)
        // {
        //     return await _repository.GetCustomerAsync(model.Name);
        // }

        // public void Add(Customer customer)
        // {
        //     _repository.Add(customer);
        // }

        // public async Task<bool> SaveChangesAsync()
        // {
        //     return await _repository.SaveChangesAsync();
        // }

        // public void Delete(Customer customer)
        // {
        //     _repository.Delete(customer);
        // }
    }
}
