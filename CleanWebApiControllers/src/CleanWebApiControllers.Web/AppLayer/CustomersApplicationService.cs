using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanWebApiControllers.Core.Interfaces;
using CleanWebApiControllers.Web.Models;

namespace CleanWebApiControllers.Web.AppLayer
{
    public class CustomersApplicationService : ICustomersApplicationService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomersApplicationService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IList<Customer> GetAll()
        {
            return new List<Customer>();
        }

        public Customer Get(string id)
        {
            return new Customer();
        }

        public Customer Update(Customer customer)
        {
            return new Customer();
        }

        public Customer Create(ClientCustomer newCustomer)
        {
            return new Customer();
        }
    }
}
