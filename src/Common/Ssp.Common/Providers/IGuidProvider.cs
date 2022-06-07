namespace Ssp.Common.Providers
{
    public interface IGuidProvider
    {
        Guid NewGuid();

        Guid Parse(string input);
    }
}