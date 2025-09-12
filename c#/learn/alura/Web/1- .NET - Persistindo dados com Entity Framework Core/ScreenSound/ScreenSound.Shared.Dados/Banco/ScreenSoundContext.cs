using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ScreenSound.Banco;

public class ScreenSoundContext : DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Genre> Genres { get; set; }

    private string connectionString = Environment.GetEnvironmentVariable("ScreenSoundDB");



    public ScreenSoundContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
        {
            return;
        }
        else
        {
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies(false);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Song>()
            .HasMany(c => c.Genres)
            .WithMany(c => c.Songs);
    }
}
