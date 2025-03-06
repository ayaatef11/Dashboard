public class Widget
{
    public string Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public bool Checked { get; set; }

    // Constructor
    public Widget(string id, string name, bool checkedValue)
    {
        Id = id;
        Name = name;
        Checked = checkedValue;
    }

  
}
