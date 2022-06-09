using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ssp.Common.Data.Projections;

public interface IProjection
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}