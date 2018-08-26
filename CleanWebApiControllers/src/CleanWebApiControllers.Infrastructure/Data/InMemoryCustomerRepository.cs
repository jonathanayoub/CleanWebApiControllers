using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanWebApiControllers.Core.Entities;
using CleanWebApiControllers.Core.Interfaces;

namespace CleanWebApiControllers.Infrastructure.Data
{
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        public IList<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(string id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Create(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
