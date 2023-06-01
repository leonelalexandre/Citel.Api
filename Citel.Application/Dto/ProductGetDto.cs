namespace Citel.Application.Dto
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public CategoryDto IdCategoryNavigation { get; set; }
    }
}
 