public class SocialMedia
{
    public string Id { get; set; }
    public string Icon { get; set; }=string.Empty;
    public string Placeholder { get; set; }=string.Empty;

    // Constructor
    public SocialMedia(string id, string icon, string placeholder)
    {
        Id = id;
        Icon = icon;
        Placeholder = placeholder;
    }

    // Default Constructor (optional, useful for serialization)
    public SocialMedia() { }
}
