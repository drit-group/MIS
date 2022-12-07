using MisSystem.Shared.Services.Contracts;

namespace MisSystem.Shared.Services.Implementations;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTimeOffset GetCurrentDateTime()
    {
        return DateTimeOffset.UtcNow;
    }
}
