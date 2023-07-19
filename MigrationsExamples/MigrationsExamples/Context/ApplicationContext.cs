using Microsoft.EntityFrameworkCore;
using MigrationsExamples.Models;

namespace MigrationsExamples.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; }

    }
}
