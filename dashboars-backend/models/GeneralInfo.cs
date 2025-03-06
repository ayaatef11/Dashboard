public class GeneralInfo
{
    public string Label { get; set; }=string.Empty;
    public string Type { get; set; }=string.Empty;
    public string Id { get; set; }=string.Empty;
    public string Placeholder { get; set; }=string.Empty;
    public string Value { get; set; }=string.Empty;
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
}
