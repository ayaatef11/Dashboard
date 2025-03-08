public class Status
{
    public int Id { get; set; }
    public string Label { get; set; }
    public int Count { get; set; }
    public string Icon { get; set; }
    public string Color { get; set; }

    public Status(int id, string label, int count, string icon, string color)
    {
        Id = id;
        Label = label;
        Count = count;
        Icon = icon;
        Color = color;
    }


}
