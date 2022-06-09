using MediatR;
using Ssp.Common;

namespace Ssp.EP.Events.Source;

public record MeteringPoint(
    string SourceSystem,
    string SourceSystemExternalId,
    string SourceSystemLastChangeTimestamp,
    string SourceSystemLastChangeUserId,
    string DeliveryType,
    string MPxN) : IEvent, IRequest;