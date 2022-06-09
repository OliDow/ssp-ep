namespace Ssp.Common.Data.Mongo;

public class MongoSettings : IMongoSettings
{
    public string ConnectionString { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;
}