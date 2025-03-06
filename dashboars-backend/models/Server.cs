public class Server
{
    public string Id { get; set; }=string.Empty;
    public string Name { get; set; }=string.Empty;
    public bool Checked { get; set; }

    // Constructor
    public Server(string id, string name, bool checkedValue)
    {
        Id = id;
        Name = name;
        Checked = checkedValue;
    }

    
}
