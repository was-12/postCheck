using Microsoft.EntityFrameworkCore;
using postCheck.Models;

namespace postCheck.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<UserModel> Users => Set<UserModel>();
    public DbSet<PostModel> Posts => Set<PostModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PostModel>()
            .HasOne(p => p.user)
            .WithMany(u => u.posts)
            .HasForeignKey(p => p.user_name)
            .OnDelete(DeleteBehavior.Cascade);
    }
}