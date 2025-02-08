
using estudo.Models;
using Microsoft.EntityFrameworkCore;


namespace estudo.Contexts
{
    public class EstudoContext: DbContext
    {

        public EstudoContext(DbContextOptions<EstudoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.OwnsOne(e => e.Cpf, cpf =>
                {
                    cpf.Property(c => c.Value)
                       .HasColumnName("Cpf")
                       .HasMaxLength(11)
                       .IsRequired();
                });
            });
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ticket> Ticket { get; set; }


    }
}
