﻿namespace MisSystem.Client.Shared.Services.Contracts;

public interface IExceptionHandler
{
    void Handle(Exception exception, IDictionary<string, object?>? parameters = null);
}
