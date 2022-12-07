using Pulumi;
using MisSystem.Iac;

public class Program
{
    static Task<int> Main() => Deployment.RunAsync<TdStack>();
}
