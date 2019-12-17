using Microsoft.EntityFrameworkCore;
using PortfolioAspNetCore.Models;

namespace PortfolioAspNetCore.DataAcces
{
    public class ExpiretisContext : DbContext
    {
        public ExpiretisContext(DbContextOptions<ExpiretisContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Expiretis> Expiretis { get; set; }
    }
}
