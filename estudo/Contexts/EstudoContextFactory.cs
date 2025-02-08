using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;


namespace estudo.Contexts
{
    public class EstudoContextFactory : IDesignTimeDbContextFactory<EstudoContext>
    {
        public EstudoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EstudoContext>();
            optionsBuilder.UseNpgsql(
                "Host=localhost;Database=estudo;Username=pgsql;Password=pgsql;");
            return new EstudoContext(optionsBuilder.Options);
        }

   
    }
}
