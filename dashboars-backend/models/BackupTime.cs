public class BackupTime
{
    public string Id { get; set; }
    public string Label { get; set; }=string.Empty;
    public bool Checked { get; set; }

    public BackupTime(string id, string label, bool checkedValue)
    {
        Id = id;
        Label = label;
        Checked = checkedValue;
    }

}
