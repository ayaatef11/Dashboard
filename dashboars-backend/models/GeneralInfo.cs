public class GeneralInfo
{
    public string Label { get; set; }
    public string Type { get; set; }
    public string Id { get; set; }
    public string Placeholder { get; set; }
    public string Value { get; set; }
    public bool Disabled { get; set; }
    public bool ShowLink { get; set; }

    // Constructor
    public GeneralInfo(string label, string type, string id, string placeholder, string value, bool disabled, bool showLink)
    {
        Label = label;
        Type = type;
        Id = id;
        Placeholder = placeholder;
        Value = value;
        Disabled = disabled;
        ShowLink = showLink;
    }

    // Default Constructor (optional)
    public GeneralInfo() { }
}
