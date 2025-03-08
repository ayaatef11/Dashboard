public class SocialPlatform
{
    public int Id { get; set; }  
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Followers { get; set; }  // Number of followers//chechk it right
    public string Action { get; set; }
    public string Classs { get; set; }

    // Constructor with parameters
    public SocialPlatform(int id, string name, string icon, string followers, string action, string classs)
    {
        Id = id;
        Name = name;
        Icon = icon;
        Followers = followers;
        Action = action;
        Classs = classs;
    }

}
