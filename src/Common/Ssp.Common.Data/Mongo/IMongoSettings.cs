namespace Ssp.Common.Data.Mongo;

public interface IMongoSettings
{
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
}