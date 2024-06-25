using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> User { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Ticket> Ticket { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Post> Post { get; set; }
}