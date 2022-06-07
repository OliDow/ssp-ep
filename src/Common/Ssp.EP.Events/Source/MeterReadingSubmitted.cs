using MediatR;
using Ssp.Common.Messaging;

namespace Ssp.EP.Events.Source;

public record MeterReadingSubmitted(string AccountNumber, string MeterSerialNumber, string Rate, DateTime SubmissionDate) : IEvent, IRequest;