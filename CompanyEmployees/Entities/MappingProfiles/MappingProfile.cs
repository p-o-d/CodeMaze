using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace Entities.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(dst => dst.FullAddress, 
                    opt => opt.MapFrom(src => string.Join(' ', src.Address, src.Country)));
        }
    }
}