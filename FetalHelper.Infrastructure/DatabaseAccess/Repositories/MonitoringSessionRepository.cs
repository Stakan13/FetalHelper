using FetalHelper.Core.Abstractions;
using FetalHelper.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FetalHelper.Infrastructure.DatabaseAccess.Repositories;

public class MonitoringSessionRepository : BaseRepository<MonitoringSession>, IMonitoringSessionRepository
{
    public MonitoringSessionRepository(FetalHelperDbContext context) : base(context) {}

    public async Task<MonitoringSession?> GetByPatientRefAsync(int patientRef)
    {
        return await dbSet.AsNoTracking().FirstOrDefaultAsync(s => s.PatientRef == patientRef);

    }
}