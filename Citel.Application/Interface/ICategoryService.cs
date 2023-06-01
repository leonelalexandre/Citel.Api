using Citel.Application.Dto;
using Citel.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citel.Application.Interface
{
    public interface ICategoryService
    {
        Task<bool> AddAsync(CategoryDto categoryDto);
        Task<bool> EditAsync(CategoryDto categoryDto);
        Task<bool> DeleteAsync(int id);
        Task<CategoryDto> GetById(int id);
        Task<IEnumerable<CategoryDto>> Filter();
    }
}
