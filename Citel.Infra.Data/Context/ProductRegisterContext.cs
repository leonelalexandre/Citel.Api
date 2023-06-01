using Microsoft.EntityFrameworkCore;
using Citel.Domain.Entity;

#nullable disable

namespace Citel.Infra.Data.Context
{
    public partial class ProductRegisterContext : DbContext
    {
        public ProductRegisterContext()
        {
        }

        public ProductRegisterContext(DbContextOptions<ProductRegisterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS02;Database=citel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductRegisterContext).Assembly);
           /* modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Categories");
            });

            OnModelCreatingPartial(modelBuilder);*/
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
