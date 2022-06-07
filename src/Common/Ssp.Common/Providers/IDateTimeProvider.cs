namespace Ssp.Common.Providers
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }

        DateTime UtcNow { get; }
    }
}