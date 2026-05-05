
using MessagingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MessagingService.Infrastructure.Persistence;

public class MessagingDbContext(DbContextOptions<MessagingDbContext> options) : DbContext(options)
{
    public DbSet<Message> Messages => Set<Message>();
    public DbSet<Like> Likes => Set<Like>();
    public DbSet<LiveClass> LiveClasses => Set<LiveClass>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Like>()
            .HasKey(l => new { l.StudentId, l.MessageId });

        modelBuilder.Entity<Message>()
            .HasMany(m => m.Likes)
            .WithOne()
            .HasForeignKey(l => l.MessageId);

     
            

    }
}
