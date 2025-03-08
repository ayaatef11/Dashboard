public class Menue
{
    public int Id { get; set; }  
    public string? Path { get; set; }
    public string? Label { get; set; }
    public string? Icon { get; set; }

    public Menue(int id, string? path = null, string? label = null, string? icon = null)
    {
        Id = id;
        Path = path;
        Label = label;
        Icon = icon;
    }


}
