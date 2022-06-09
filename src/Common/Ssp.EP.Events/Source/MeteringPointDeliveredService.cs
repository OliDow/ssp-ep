using MediatR;
using Ssp.Common;

namespace Ssp.EP.Events.Source;

public record MeteringPointDeliveredService(
    string SourceSystem,
    string SourceSystemExternalId,
    string SourceSystemLastChangeTimestamp,
    string SourceSystemLastChangeUserId,
    string SourceSystemDeliveredService,
    string SourceSystemExternalIdDeliveredService,
    string SourceSystemMeteringPoint,
    string SourceSystemExternalIdMeteringPoint,
    string StartDate,
    string EndDate) : IEvent, IRequest;