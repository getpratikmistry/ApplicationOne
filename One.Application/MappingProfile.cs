using AutoMapper;
using One.Application.Dto;
using One.Domain.Entities;

namespace One.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Product Mappings
            CreateMap<UserDetail, UserDetailDto>().ReverseMap();
        }
    }
}
