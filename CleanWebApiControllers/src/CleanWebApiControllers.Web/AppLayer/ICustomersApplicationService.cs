using System.Collections.Generic;
using CleanWebApiControllers.Web.Models;

namespace CleanWebApiControllers.Web.AppLayer
{
    public interface ICustomersApplicationService
    {
        IList<Customer> GetAll();
        Customer Get(string id);
        Customer Update(Customer customer);
        Customer Create(ClientCustomer newCustomer);
    }
}