namespace FetalHelper.Core.Abstractions;

public interface IBaseRepository<T> where T : class
{
    Task<T?> GetByIdAsync(Guid id);
    Task<bool> CreateAsync(T entity);
}