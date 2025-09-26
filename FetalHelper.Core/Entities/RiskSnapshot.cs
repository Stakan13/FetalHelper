using FetalHelper.Core.Enums.RiskSnapshotsEnums;

namespace FetalHelper.Core.Entities;

public class RiskSnapshot
{
    public Guid Id { get; set; }
    public Guid SessionId  { get; set; }
    public DateTime CalculatedAt { get; set; }
    public TimeSpan HorizonMinutes { get; set; }
    public float RiskScore { get; set; }
    public RiskSnapshotMetrics Metrics { get; set; }
    
    public RiskSnapshot() {}

    private RiskSnapshot(Guid id, Guid sessionId, DateTime calculatedAt, TimeSpan horizonMinutes, float riskScore,
        RiskSnapshotMetrics metrics)
    {
        Id = id;
        SessionId = sessionId;
        CalculatedAt = calculatedAt;
        HorizonMinutes = horizonMinutes;
        RiskScore = riskScore;
        Metrics = metrics;
    }

    public static RiskSnapshot Create(Guid sessionId, DateTime calculatedAt, TimeSpan horizonMinutes, float riskScore,
        RiskSnapshotMetrics metrics)
    {
        return new RiskSnapshot(Guid.NewGuid(), sessionId, calculatedAt, horizonMinutes, riskScore, metrics);
    }
}