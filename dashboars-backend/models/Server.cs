public class Server
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool Checked { get; set; }

    // Constructor
    public Server(string id, string name, bool checkedValue)
    {
        Id = id;
        Name = name;
        Checked = checkedValue;
    }

    // Default Constructor (optional)
    public Server() { }
}
