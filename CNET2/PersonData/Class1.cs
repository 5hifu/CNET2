using Microsoft.EntityFrameworkCore;
using PersonModel;

namespace PersonData;

public class PeopleContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Contract> Contracts { get; set; }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=C:\Users\Student\source\repos\kubicek-skoleni\CNET2\CNET2\people.db");
}
