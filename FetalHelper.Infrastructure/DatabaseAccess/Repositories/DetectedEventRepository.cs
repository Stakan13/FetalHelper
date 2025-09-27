using FetalHelper.Core.Abstractions;
using FetalHelper.Core.Entities;

namespace FetalHelper.Infrastructure.DatabaseAccess.Repositories;

public class DetectedEventRepository : BaseRepository<DetectedEvent>, IDetectedEventRepository
{
    public DetectedEventRepository(FetalHelperDbContext dbContext) : base(dbContext) {}
}