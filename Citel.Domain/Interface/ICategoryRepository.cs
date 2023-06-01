using Citel.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citel.Domain.Interface
{
    public interface ICategoryRepository
    {
        Task AddAsync(Category category);
        Task EditAsync(Category category);
        Task DeleteAsync(Category category);
        Task<Category> GetById(int id);
        Task<IEnumerable<Category>> Filter();
        Task<bool> SaveAllAsync();
    }
}
