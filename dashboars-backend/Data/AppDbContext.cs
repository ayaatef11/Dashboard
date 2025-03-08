using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Menue> MenuItems { get; set; }
    public DbSet<SettingsItem>SettingsItems {get;set;}
    public DbSet<BackupTime>BackupTimes {get;set;}
    public DbSet<GeneralInfo>GeneralInfos {get;set;}
    public DbSet<Server>Servers {get;set;}
    public DbSet<SocialMedia>SocialMedias {get;set;}
    public DbSet<Widget>Widgets {get;set;}
    public DbSet<Project>Projects {get;set;}
    public DbSet<Activity>Activitys {get;set;}
    public DbSet<Friend>Friends {get;set;}
    public DbSet<File>Files {get;set;}
    public DbSet<Course>Courses{get;set;}
    public DbSet<Dashboard>Dashboards{get;set;}
    public DbSet<Feature>Features{get;set;}
    public DbSet<FileCategory>FileCategories{get;set;}
    public DbSet<Keyword>Keywords{get;set;}
    public DbSet<NewItem>NewItems{get;set;}
    public DbSet<Plan>Plans{get;set;}
    public DbSet<SocialPlatform>SocialPlatforms{get;set;}
    public DbSet<Status>Statuses{get;set;}
    public DbSet<Target>Targets{get;set;}
    public DbSet<Task>Tasks{get;set;}
    public DbSet<UserProfile>UsersProfiles{get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer("DefaultConnection");//not recommended
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedData();
    }
}
