using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace API
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company,CompanyDto>().ForMember(c=>c.NameWithCount,opt=>opt.MapFrom(x=>string.Join('-',x.name,x.employeeCount)));
            CreateMap<CompanyForCreationDto,Company>();
        }
    }
}