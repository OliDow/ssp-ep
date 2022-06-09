namespace Ssp.Common.Data.Providers;

public interface ICommandProvider
{
    Task<string> SendCommandAsync(IEvent payload, CancellationToken cancellationToken);
}