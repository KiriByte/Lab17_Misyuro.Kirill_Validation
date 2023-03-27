using Lab17_Misyuro.Kirill_Validation.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab17_Misyuro.Kirill_Validation.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}