public class SocialMedia
{
    public string Id { get; set; }
    public string Icon { get; set; }
    public string Placeholder { get; set; }

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
