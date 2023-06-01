using Citel.Domain.Entity;
using Citel.Domain.Interface;
using Citel.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citel.Api.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductRegisterContext _context;
        public CategoryRepository(ProductRegisterContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Category category)
        {
            await Task.Run(
                () => _context.Add(category)
            );
        }

        public async Task DeleteAsync(Category category)
        {
            await Task.Run(
                () => _context.Remove(category)
            );
        }

        public async Task EditAsync(Category category)
        {
            await Task.Run(
              () => _context.Entry(category).State = EntityState.Modified
            );
        }

        public async Task<IEnumerable<Category>> Filter()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            Category category;

            return category = await _context.Categories.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
