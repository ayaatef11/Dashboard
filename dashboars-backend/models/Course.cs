public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Cover { get; set; }
    public string Instructor { get; set; }
    public int Students { get; set; }
    public decimal Price { get; set; }

    public Course(int id, string title, string description, string cover, string instructor, int students, decimal price)
    {
        Id = id;
        Title = title;
        Description = description;
        Cover = cover;
        Instructor = instructor;
        Students = students;
        Price = price;
    }

}
