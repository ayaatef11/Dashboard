public class FileCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }
    public double Size { get; set; }
    public string Icon { get; set; }
    public string Color { get; set; }

    // Constructor with parameters
    public FileCategory(int id, string name, int count, double size, string icon, string color)
    {
        Id = id;
        Name = name;
        Count = count;
        Size = size;
        Icon = icon;
        Color = color;
    }

    
}
