using System.Collections.Generic;

public class Plan
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<Feature> Features { get; set; }

    public Plan(int id = 0, string name = "", decimal price = 0, List<Feature>? features = null)
    {
        Id = id;
        Name = name;
        Price = price;
        Features = features ?? new List<Feature>(); 
    }


}
