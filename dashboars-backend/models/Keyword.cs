public class Keyword
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }

    public Keyword(int id, string name, int count)
    {
        Id = id;
        Name = name;
        Count = count;
    }

}
