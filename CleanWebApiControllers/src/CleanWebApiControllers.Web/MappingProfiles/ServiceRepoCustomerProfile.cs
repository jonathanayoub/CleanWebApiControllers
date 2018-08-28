using AutoMapper;

namespace CleanWebApiControllers.Web.MappingProfiles
{
    public class ServiceRepoCustomerProfile : Profile
    {
        public ServiceRepoCustomerProfile()
        {
            CreateMap<Models.Customer, Core.Entities.Customer>();
            CreateMap<Core.Entities.Customer, Models.Customer>();
            CreateMap<Models.ClientCustomer, Core.Entities.Customer>();
        }
    }
}
