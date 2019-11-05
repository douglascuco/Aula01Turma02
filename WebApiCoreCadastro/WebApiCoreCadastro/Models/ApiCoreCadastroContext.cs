using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiCoreCadastro.Models
{
    public partial class ApiCoreCadastroContext : DbContext
    {
        public ApiCoreCadastroContext()
        {
        }

        public ApiCoreCadastroContext(DbContextOptions<ApiCoreCadastroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Login).HasMaxLength(30);

                entity.Property(e => e.Nome).HasMaxLength(50);

                entity.Property(e => e.Senha).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
