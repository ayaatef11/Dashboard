public class Target
{
    public int Id { get; set; }  
    public string Type { get; set; }
    public string Amount { get; set; }
    public string Icon { get; set; }
    public string Color { get; set; }
    public int Progress { get; set; }

    // Constructor with parameters
    public Target(int id, string type, string amount, string icon, string color, int progress)
    {
        Id = id;
        Type = type;
        Amount = amount;
        Icon = icon;
        Color = color;
        Progress = progress;
    }

}
