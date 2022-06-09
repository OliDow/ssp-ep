using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Ssp.Common.Data.Mongo;

namespace Ssp.Common.Data.Projections;

public class ProjectionRepository : IProjectionRepository
{
    private readonly MongoSettings _mongoSettings;
    private readonly IMongoDatabase _database;

    public ProjectionRepository(IOptions<MongoSettings> mongoOptions)
    {
        _mongoSettings = mongoOptions.Value ?? throw new ArgumentNullException(nameof(mongoOptions));

        var client = new MongoClient(_mongoSettings.ConnectionString);
        _database = client.GetDatabase(_mongoSettings.DatabaseName);
    }

    public async Task<IReadOnlyCollection<IProjection>> GetProjectionsAsync(string partitionKey,
        CancellationToken cancellationToken)
    {
        // todo Go to datasource to get Projections
        await Task.Delay(1, cancellationToken); // todo remove

        return new List<IProjection>();
    }

    public async Task UpsertAsync(ICollection<IProjection> generatedProjections, CancellationToken cancellationToken)
    {
        // todo Needs to be a merge not just bulk insert
        var projectionsCollection = _database.GetCollection<IProjection>("MeterProjection");
        await projectionsCollection.InsertManyAsync(generatedProjections, cancellationToken: cancellationToken);
    }
}