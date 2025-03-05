using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<menueItem> MenuItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer("DefaultConnection");//not recommended
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
  //iterate over menueitems in the json file
  var menueItemsJson=Path.Combine(Directory.GetCurrentDirectory(), "DataSeeding", "menuItems.json");

        var menuItemsJson = File.ReadAllText(menueItemsJson);
        var items = JsonConvert.DeserializeObject<List<menueItem>>(menuItemsJson);

        if (items != null)
        {
            modelBuilder.Entity<menueItem>().HasData(items);
        }

}
}
