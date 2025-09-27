using FetalHelper.Core.Abstractions;
using FetalHelper.Core.Entities;

namespace FetalHelper.Infrastructure.DatabaseAccess.Repositories;

public class RiskSnapshotRepository : BaseRepository<RiskSnapshot>,  IRiskSnapshotRepository
{
    public RiskSnapshotRepository(FetalHelperDbContext dbContext) : base(dbContext) {}
}