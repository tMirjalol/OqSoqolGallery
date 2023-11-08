using Microsoft.EntityFrameworkCore;
using OqSoqolGallery.Domain.Entities;

namespace OqSoqolGallery.Date.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    { }

    public DbSet<User> Users { get; set; }
}
