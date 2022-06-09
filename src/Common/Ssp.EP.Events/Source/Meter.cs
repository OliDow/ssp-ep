using MediatR;
using Ssp.Common;

namespace Ssp.EP.Events.Source;

public record Meter(
    string SourceSystem,
    string SourceSystemExternalId,
    string SourceSystemLastChangeTimestamp,
    string SourceSystemLastChangeUserId,
    string SerialNumber,
    string MeterType,
    string SmartCapability) : IEvent, IRequest;