using MisSystem.Shared.Dtos.Account;

namespace MisSystem.Client.Shared.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
