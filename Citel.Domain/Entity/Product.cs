using System;
using System.Collections.Generic;

#nullable disable

namespace Citel.Domain.Entity
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int IdCategory { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
    }
}
