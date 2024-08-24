using lifescience.Models;
using Microsoft.EntityFrameworkCore;

public class contactContext : DbContext
{
    public DbSet<contact> Contacts { get; set; }

    public contactContext(DbContextOptions<contactContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Define any additional configuration here
    }
}
