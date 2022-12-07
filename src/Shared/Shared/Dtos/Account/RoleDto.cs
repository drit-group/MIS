using MisSystem.Shared.Attributes;
using MisSystem.Shared.Resources;

namespace MisSystem.Shared.Dtos.Account;

[DtoResourceType(typeof(AppStrings))]
public class RoleDto
{
    public int Id { get; set; }

    public string? Name { get; set; }
}
