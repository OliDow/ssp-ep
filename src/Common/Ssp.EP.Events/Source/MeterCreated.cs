using MediatR;
using Ssp.Common.Messaging;

namespace Ssp.EP.Events.Source;

public record MeterCreated(
    string MeterSerialNumber,
    string FuelType,
    string SiteAddress,
    string MeterPointNumber,
    string MeterType) : IEvent, IRequest;