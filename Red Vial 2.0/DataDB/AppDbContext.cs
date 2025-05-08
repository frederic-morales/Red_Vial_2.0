using Microsoft.EntityFrameworkCore;
namespace Red_Vial_2._0;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }

    public DbSet<InformacionNodo> InformacionNodo { get; set; }
}