using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CleanWebApiControllers.Web.MappingProfiles
{
    public class ServiceRepoCustomerProfile : Profile
    {
        public ServiceRepoCustomerProfile()
        {
            CreateMap<Models.Customer, Core.Entities.Customer>();
            CreateMap<Core.Entities.Customer, Models.Customer>();
        }
    }
}
