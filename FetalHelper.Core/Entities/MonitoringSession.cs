using FetalHelper.Core.Enums;
using FetalHelper.Core.Enums.MonitoringSessionEnums;

namespace FetalHelper.Core.Entities;

public class MonitoringSession
{
    public Guid Id { get; set; }
    public MonitoringSessionMode Mode { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public MonitoringSessionStatus Status { get; set; }
    public int PatientRef { get; set; }
    public byte GestationalAgeWeeks { get; set; }
    public int DeviceId { get; set; }
    public int SampleRateHz { get; set; }
    public List<RiskSnapshot> Snapshots { get; set; } = null!;
    public List<DetectedEvent> Events { get; set; } = null!;
    public List<Annotation> Annotations { get; set; } = null!;
    
    public MonitoringSession() { }

    private MonitoringSession(Guid id, MonitoringSessionMode mode, DateTime startTime, DateTime endTime,
        MonitoringSessionStatus status, int patientRef, byte gestationalAgeWeeks, int deviceId,
        int sampleRateHz)
    {
        Id = id;
        Mode = mode;
        StartTime = startTime;
        EndTime = endTime;
        Status = status;
        PatientRef = patientRef;
        GestationalAgeWeeks = gestationalAgeWeeks;
        DeviceId = deviceId;
        SampleRateHz = sampleRateHz;
    }

    public static MonitoringSession Create(MonitoringSessionMode mode, DateTime startTime, DateTime endTime,
        MonitoringSessionStatus status, int patientRef, byte gestationalAgeWeeks, int deviceId, int sampleRateHz)
    {
        return new MonitoringSession(Guid.NewGuid(), mode,  startTime, endTime, status, patientRef, 
            gestationalAgeWeeks, deviceId, sampleRateHz);
    }
}