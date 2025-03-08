using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

public static class ModelBuilderExtensions
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        string dataPath = Path.Combine(Directory.GetCurrentDirectory(), "DataSeeding");

        modelBuilder.SeedJsonData<menueItem>(dataPath, "menuItems.json");
        modelBuilder.SeedJsonData<SettingsItem>(dataPath, "SettingsItems.json");
        modelBuilder.SeedJsonData<BackupTime>(dataPath, "BackupTimes.json");
        modelBuilder.SeedJsonData<GeneralInfo>(dataPath, "GeneralInfos.json");
        modelBuilder.SeedJsonData<Server>(dataPath, "Servers.json");
        modelBuilder.SeedJsonData<SocialMedia>(dataPath, "SocialMedias.json");
        modelBuilder.SeedJsonData<Widget>(dataPath, "Widgets.json");
        modelBuilder.SeedJsonData<Project>(dataPath, "Projects.json");
        modelBuilder.SeedJsonData<Activity>(dataPath, "activities.json");
        modelBuilder.SeedJsonData<Friend>(dataPath, "Friends.json");
        modelBuilder.SeedJsonData<Files>(dataPath, "Files.json");

    }

    private static void SeedJsonData<T>(this ModelBuilder modelBuilder, string directory, string fileName) where T : class
    {
        string filePath = Path.Combine(directory, fileName);
        if (File.Exists(filePath))
        {
            var jsonData = File.ReadAllText(filePath);
            var items = JsonConvert.DeserializeObject<List<T>>(jsonData);
            if (items != null)
            {
                modelBuilder.Entity<T>().HasData(items);
            }
        }
    }
}
