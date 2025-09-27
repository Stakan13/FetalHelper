using FetalHelper.Core.Abstractions;
using FetalHelper.Core.Entities;

namespace FetalHelper.Infrastructure.DatabaseAccess.Repositories;

public class AnnotationRepository : BaseRepository<Annotation>, IAnnotationRepository
{
    public  AnnotationRepository(FetalHelperDbContext dbContext) : base(dbContext) {}
}