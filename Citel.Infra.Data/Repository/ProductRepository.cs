using Citel.Domain.Entity;
using Citel.Domain.Interface;
using Citel.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citel.Api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductRegisterContext _context;
        public ProductRepository(ProductRegisterContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Product product)
        {
            await Task.Run(
                () => _context.Add(product)
            );
        }

        public async Task DeleteAsync(Product product)
        {
            await Task.Run(
                () => _context.Remove(product)
            );
        }

        public async Task EditAsync(Product product)
        {
            await Task.Run(
              () => _context.Entry(product).State = EntityState.Modified
            );
        }

        public async Task<IEnumerable<Product>> Filter()
        {
            return await _context.Products.Include(x => x.IdCategoryNavigation).ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            Product product;

            return product = await _context.Products
                .Include(x=> x.IdCategoryNavigation)
                .Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
