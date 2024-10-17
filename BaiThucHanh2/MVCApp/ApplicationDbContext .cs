using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Define your DbSets here (e.g., Foods table)
    public DbSet<MVCApp.Models.Food> Foods { get; set; }





    
}