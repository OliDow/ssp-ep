using MediatR;
using Ssp.Common;

namespace Ssp.EP.Events.Source;

public record MeteringPointMeter(
    string SourceSystem,
    string SourceSystemExternalId,
    string SourceSystemLastChangeTimestamp,
    string SourceSystemLastChangeUserId,
    string SourceSystemMeteringPoint,
    string SourceSystemMeter,
    string SourceSystemExternalIdMeter,
    string StartDate,
    string EndDate) : IEvent, IRequest;