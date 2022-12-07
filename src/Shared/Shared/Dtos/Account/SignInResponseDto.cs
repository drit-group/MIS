using MisSystem.Shared.Attributes;
using MisSystem.Shared.Resources;

namespace MisSystem.Shared.Dtos.Account;

[DtoResourceType(typeof(AppStrings))]
public class SignInResponseDto
{
    public string? AccessToken { get; set; }

    public long ExpiresIn { get; set; }
}
