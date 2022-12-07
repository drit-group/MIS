using System.Diagnostics;
using MisSystem.Client.Shared.Shared;
using MisSystem.Shared.Dtos.TodoItem;

namespace MisSystem.Client.Shared.Services.Implementations;

public partial class ExceptionHandler : IExceptionHandler
{
    [AutoInject] IStringLocalizer<AppStrings> _localizer = default!;

    public void Handle(Exception exception, IDictionary<string, object?>? parameters = null)
    {
#if DEBUG
        string exceptionMessage = (exception as KnownException)?.Message ?? exception.ToString();
        // TODO: No more messagebox to show!
        // MessageBox.Show(exceptionMessage, _localizer[nameof(AppStrings.Error)]);
        Console.WriteLine(exceptionMessage);
        Debugger.Break();
#else
        if (exception is KnownException knownException)
        {
            // MessageBox.Show(knownException.Message, _localizer[nameof(AppStrings.Error)]);
        }
        else
        {
            // MessageBox.Show(_localizer[nameof(AppStrings.UnknownException)], _localizer[nameof(AppStrings.Error)]);
        }
#endif

    }
}
