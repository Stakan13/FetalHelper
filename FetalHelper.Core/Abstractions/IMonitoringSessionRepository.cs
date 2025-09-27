using FetalHelper.Core.Entities;

namespace FetalHelper.Core.Abstractions;

public interface IMonitoringSessionRepository : IBaseRepository<MonitoringSession>
{
    Task<MonitoringSession?> GetByPatientRefAsync(int patientRef);
}