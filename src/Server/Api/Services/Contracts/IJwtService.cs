using MisSystem.Server.Api.Models.Account;
using MisSystem.Shared.Dtos.Account;

namespace MisSystem.Server.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
