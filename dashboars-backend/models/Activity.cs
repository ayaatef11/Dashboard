public class Activity
{
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Time { get; set; }
    public string Date { get; set; }

    public Activity(string image, string title, string description, string time, string date)
    {
        Image = image;
        Title = title;
        Description = description;
        Time = time;
        Date = date;
    }
}
