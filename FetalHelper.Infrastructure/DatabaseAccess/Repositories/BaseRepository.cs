using FetalHelper.Core.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace FetalHelper.Infrastructure.DatabaseAccess.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class, IIdentifiable
{
    protected FetalHelperDbContext Db;
    protected DbSet<T> dbSet;

    public BaseRepository(FetalHelperDbContext context)
    {
        Db = context ?? throw new ArgumentNullException(nameof(context));
        dbSet = Db.Set<T>();
    }

    public virtual async Task<T?> GetByIdAsync(Guid id)
    {
        return await dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public virtual async Task<Guid> CreateAsync(T entity)
    {
        await dbSet.AddAsync(entity);
        return await Db.SaveChangesAsync() > 0 ? entity.Id : Guid.Empty;
    }
}