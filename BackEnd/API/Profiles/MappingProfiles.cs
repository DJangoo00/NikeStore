using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Role,RoleDto>().ReverseMap();
        CreateMap<User,UserDto>().ReverseMap();
    }
}