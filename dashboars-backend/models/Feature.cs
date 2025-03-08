public class Feature
{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool Available { get; set; }

    public Feature(int id, string text, bool available)
    {
        Id = id;
        Text = text;
        Available = available;
    }

}
