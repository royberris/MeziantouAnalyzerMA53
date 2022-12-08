using Microsoft.EntityFrameworkCore;

namespace MeziantouAnalyzerMA53.Database;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Foo> Foos => Set<Foo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Foo>()
            .Property(i => i.Name)
            .HasMaxLength(4);
    }
}
