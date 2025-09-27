using FetalHelper.Core.Abstractions;
using FetalHelper.Core.Enums.DetectedEventEnums;

namespace FetalHelper.Core.Entities;

public class DetectedEvent : IIdentifiable
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public DetectedEventType Type { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
    public double Confidence { get; set; }
    
    public DetectedEvent() {}

    private DetectedEvent(Guid id, Guid sessionId, DetectedEventType type, DateTime startAt, DateTime endAt, 
        double confidence)
    {
        Id = id;
        SessionId = sessionId;
        Type = type;
        StartAt = startAt;
        EndAt = endAt;
        Confidence = confidence;
    }

    public static DetectedEvent Create(Guid sessionId, DetectedEventType type, DateTime startAt, DateTime endAt,
        double confidence)
    {
        return new DetectedEvent(Guid.NewGuid(), sessionId, type, startAt, endAt, confidence);
    }
}