
using Microsoft.EntityFrameworkCore;

namespace EfCoreTrackingDataChangesDemo;

public class StorageBroker : DbContext
{
	public StorageBroker() =>
		this.Database.Migrate();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=EfCoreTrackingDataChangesDemoDb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Student>()
            .ToTable("Students", studentsTable => studentsTable.IsTemporal());
    }

    public DbSet<Student> Students { get; set; }
}