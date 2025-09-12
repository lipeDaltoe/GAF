using GAF.Api.Models;

namespace GAF.Api.Repositories.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllByUserIdAsync(string userId);
    Task<Category> GetByIdAsync(int id, string userId);
    Task<Category> GetByNameAsync(string name, string userId);
    Task<Category> CreateAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task<bool> DeleteAsync(int id, string userId);
    Task<bool> HasTransactionAsync(int categoryId, string userId);
}
