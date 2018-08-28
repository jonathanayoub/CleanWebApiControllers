using System;
using System.Collections.Generic;
using System.Linq;
using CleanWebApiControllers.Core.Entities;
using CleanWebApiControllers.Core.Interfaces;

namespace CleanWebApiControllers.Infrastructure.Data
{
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private static List<Customer> _customers;

        static InMemoryCustomerRepository()
        {
            SeedCustomers();
        }

        private static void SeedCustomers()
        {
            _customers = new List<Customer>
            {
                new Customer
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "John",
                    LastName = "Smith",
                    FavoriteIceCream = "Moose Tracks"
                },
                new Customer
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Paul",
                    LastName = "Bunyan",
                    FavoriteIceCream = "Chocolate"
                },
                new Customer
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Jenny",
                    LastName = "Parks",
                    FavoriteIceCream = "Vanilla"
                }
            };
        }

        public IList<Customer> GetAll()
        {
            return _customers;
        }

        public Customer Get(string id)
        {
            return _customers.SingleOrDefault(c => c.Id == id);
        }

        public Customer Update(Customer customer)
        {
            var existingCustomer = _customers.SingleOrDefault(c => c.Id == customer.Id);
            if(existingCustomer == null)
                throw new ArgumentException("Attempt to update a customer that doesn't exist");
            existingCustomer.FavoriteIceCream = customer.FavoriteIceCream;
            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            return existingCustomer;
        }

        public Customer Create(Customer customer)
        {
            var newCustomerId = Guid.NewGuid().ToString();
            customer.Id = newCustomerId;
            _customers.Add(customer);
            return customer;
        }
    }
}
