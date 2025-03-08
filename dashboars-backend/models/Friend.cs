public class Friend
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public string Image { get; set; }
    public int FriendsCount { get; set; }
    public int Projects { get; set; }
    public int Articles { get; set; }
    public DateTime Joined { get; set; }
    public bool IsVip { get; set; }

    public Friend(int id, string name, string role, string image, int friendsCount,
                  int projects, int articles, DateTime joined, bool isVip)
    {
        Id = id;
        Name = name;
        Role = role;
        Image = image;
        FriendsCount = friendsCount;
        Projects = projects;
        Articles = articles;
        Joined = joined;
        IsVip = isVip;
    }
}
