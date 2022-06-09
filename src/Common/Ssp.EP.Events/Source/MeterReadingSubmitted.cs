using MediatR;
using Ssp.Common;
using Ssp.Common.Messaging;

namespace Ssp.EP.Events.Source;

public record MeterReadingSubmitted(
    string AccountNumber,
    string MeterPointNumber,
    string Rate,
    string RateType,
    string ReadingType,
    DateTime SubmissionDate) : IEvent, IRequest;