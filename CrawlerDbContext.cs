using ExportData.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExportData;

public class CrawlerDbContext : DbContext
{
    public DbSet<CrawlerCommand> CrawlerCommands { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TestCrawler;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
