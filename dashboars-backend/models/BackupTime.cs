public class BackupTime
{
    public string Id { get; set; }
    public string Label { get; set; }=string.Empty;
    public bool Checked { get; set; }

    // Constructor
    public BackupTime(string id, string label, bool checkedValue)
    {
        Id = id;
        Label = label;
        Checked = checkedValue;
    }

    // Default Constructor (optional)
    public BackupTime() { }
}
