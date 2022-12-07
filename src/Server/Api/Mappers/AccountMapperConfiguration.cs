using MisSystem.Server.Api.Models.Account;
using MisSystem.Shared.Dtos.Account;

namespace MisSystem.Server.Api.Mappers;

public class AccountMapperConfiguration : Profile
{
    public AccountMapperConfiguration()
    {
        CreateMap<Role, RoleDto>().ReverseMap();

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, EditUserDto>().ReverseMap();
        CreateMap<User, SignUpRequestDto>()
            .ReverseMap();
    }
}
