using System.Runtime.Serialization;
using MisSystem.Shared.Resources;

namespace MisSystem.Shared.Exceptions;

[Serializable]
public class UnknownException : ApplicationException
{
    public UnknownException()
        : base(nameof(AppStrings.UnknownException))
    {
    }

    public UnknownException(string message)
        : base(message)
    {
    }

    public UnknownException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected UnknownException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}

