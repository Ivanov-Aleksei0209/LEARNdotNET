using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MigrationsExamples.Models;

namespace MigrationsExamples.Areas.Identity.Data;

public class MigrationsExamplesIdentityDbContext : IdentityDbContext<User>
{
    public MigrationsExamplesIdentityDbContext(DbContextOptions<MigrationsExamplesIdentityDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> User { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
