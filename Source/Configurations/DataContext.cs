using Microsoft.EntityFrameworkCore;
using Shopopolis.Source.Core.Models;

namespace Shopopolis.Source.Configurations;

class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionStr = "server=localhost;user=root;password='';database=shopopolis";

        var serverVersion = new MySqlServerVersion(new Version(10, 4, 28));

        optionsBuilder.UseMySql(connectionString: connectionStr, serverVersion: serverVersion);

        base.OnConfiguring(optionsBuilder);
    }
}
