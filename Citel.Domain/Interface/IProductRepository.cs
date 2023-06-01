using Citel.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citel.Domain.Interface
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task EditAsync(Product product);
        Task DeleteAsync(Product product);
        Task<Product> GetById(int id);
        Task<IEnumerable<Product>> Filter();
        Task<bool> SaveAllAsync();
    }
}
