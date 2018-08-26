using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanWebApiControllers.Core.Entities;

namespace CleanWebApiControllers.Core.Interfaces
{
    public interface ICustomerRepository
    {
        IList<Customer> GetAll();
        Customer Get(string id);
        Customer Update(Customer customer);
        Customer Create(Customer customer);
    }
}
