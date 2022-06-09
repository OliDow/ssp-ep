namespace Ssp.Common.Data.Providers;

public class CommandProvider : ICommandProvider
{
    public CommandProvider() { }
// }IHttpClientFactory clientFactory) { }

    public async Task<string> SendCommandAsync(IEvent payload, CancellationToken cancellationToken)
    {
        await Task.Delay(1, cancellationToken); // todo remove

        return string.Empty;
    }
}