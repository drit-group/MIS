namespace MisSystem.Shared.Services.Contracts;

public interface IDateTimeProvider
{
    DateTimeOffset GetCurrentDateTime();
}
