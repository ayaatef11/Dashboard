public class Task
{
    public int Id { get; set; }  
    public string Title { get; set; }
    public string Description { get; set;}
    public bool Done { get; set; }

    // Constructor with parameters
    public Task(int id, string title, string description, bool done)
    {
        Id = id;
        Title = title;
        Description = description;
        Done = done;
    }


}
