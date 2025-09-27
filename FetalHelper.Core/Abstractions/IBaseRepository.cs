namespace FetalHelper.Core.Abstractions;

public interface IBaseRepository<T> where T : class, IIdentifiable
{
    Task<T?> GetByIdAsync(Guid id);
    Task<Guid> CreateAsync(T entity);
}