using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<menueItem> MenuItems { get; set; }
    public DbSet<SettingsItem>SettingsItems {get;set;}
    public DbSet<BackupTime>BackupTimes {get;set;}
    public DbSet<GeneralInfo>GeneralInfos {get;set;}
    public DbSet<Server>Servers {get;set;}
    public DbSet<SocialMedia>SocialMedias {get;set;}
    public DbSet<Widget>Widgets {get;set;}
    public DbSet<Project>Projects {get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer("DefaultConnection");//not recommended
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedData();
    }
}
