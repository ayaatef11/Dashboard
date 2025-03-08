public class NewItem
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string TimeAgo { get; set; }  

    public NewItem(int id, string image, string title, string description, string timeAgo)
    {
        Id = id;
        Image = image;
        Title = title;
        Description = description;
        TimeAgo = timeAgo;
    }


}
