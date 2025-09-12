using GAF.Api.Models;
using GAF.Api.Repositories.Interfaces;

namespace GAF.Api.Repositories;

public class CategoryRepository : ICategoryRepository
{
    public Task<IEnumerable<Category>> GetAllByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetByIdAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetByNameAsync(string name, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> CreateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<Category> UpdateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasTransactionAsync(int categoryId, string userId)
    {
        throw new NotImplementedException();
    }
}
