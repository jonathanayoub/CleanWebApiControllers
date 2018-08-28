using System;
using System.Collections.Generic;
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
            var repoCustomers = _customerRepository.GetAll();
            var apiCustomers = _mapper.Map<IList<Customer>>(repoCustomers);
            return apiCustomers;
        }

        public Customer Get(string id)
        {
            var repoCustomer = _customerRepository.Get(id);
            var apiCustomer = _mapper.Map<Customer>(repoCustomer);
            return apiCustomer;
        }

        public Customer Update(Customer customer)
        {
            var repoCustomer = _mapper.Map<Core.Entities.Customer>(customer);
            var result = _customerRepository.Update(repoCustomer);
            return _mapper.Map<Customer>(result);
        }

        public Customer Create(ClientCustomer newCustomer)
        {
            var repoCustomer = _mapper.Map<Core.Entities.Customer>(newCustomer);
            var result = _customerRepository.Create(repoCustomer);
            return _mapper.Map<Customer>(result);
        }
    }
}
