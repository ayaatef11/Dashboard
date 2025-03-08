public class Activity
{
  public int Id{get;set;}
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Time { get; set; }
    public string Date { get; set; }

    public Activity(int id,string image, string title, string description, string time, string date)
    {
      Id=id;
        Image = image;
        Title = title;
        Description = description;
        Time = time;
        Date = date;
    }
}
