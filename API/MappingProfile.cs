using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace API
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company,CompanyDto>().ForCtorParam("NameWithCount",opt=>opt.MapFrom(x=>string.Join('-',x.name,x.employeeCount)));
        }
    }
}