using AutoMapper;
using TaskAPI.Dtos;
using TaskAPI.Models;

namespace TaskAPI.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Address,
                opt => opt.MapFrom(src => $"{src.AddressNo},{src.Street},{src.City}"));
            CreateMap<CreateAuthorDto, Author>(); //source -to-> destination
        }
    }
}
