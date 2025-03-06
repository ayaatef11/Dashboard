using System;
using System.Collections.Generic;

public class Project
{
    public int Id { get; set; }
    public string Data { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Team { get; set; }
    public List<string> Categories { get; set; }
    public string Progress { get; set; }
    public decimal Price { get; set; }

    // Constructor
    public Project(int id, string data, string title, string description, string team, List<string> categories, string progress, decimal price)
    {
        Id = id;
        Data = data;
        Title = title;
        Description = description;
        Team = team;
        Categories = categories;
        Progress = progress;
        Price = price;
    }
}
