public class File
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Owner { get; set; }
    public DateTime Date { get; set; }
    public string Size { get; set; }

    // Constructor
    public File(int id, string name, string type, string owner, DateTime date, string size)
    {
        Id = id;
        Name = name;
        Type = type;
        Owner = owner;
        Date = date;
        Size = size;
    }
}
