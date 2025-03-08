using System;
using System.Collections.Generic;

public class UserProfile
{
    public int Id { get; set; }  // Unique identifier
    public string FullName { get; set; }
    public string Gender { get; set; }
    public string Country { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Title { get; set; }
    public string ProgrammingLanguage { get; set; }
    public string YearsOfExperience { get; set; }
    public string PaymentMethod { get; set; }
    public string BillingEmail { get; set; }
    public string Subscription { get; set; }
    public List<List<string>> Skills { get; set; }
    public List<string> Activities { get; set; }

    public UserProfile()
    {
        FullName = "Osama Mohamed";
        Gender = "Male";
        Country = "Egypt";
        Email = "o.nn.sa";
        Phone = "019123456789";
        DateOfBirth = new DateTime(1982, 10, 25);
        Title = "Full Stack Developer";
        ProgrammingLanguage = "Python";
        YearsOfExperience = "15+";
        PaymentMethod = "Paypal";
        BillingEmail = "email.website.com";
        Subscription = "Monthly";
        Skills = new List<List<string>>
        {
            new List<string> { "HTML", "Pugjs", "HAML" },
            new List<string> { "CSS", "SASS", "Stylus" },
            new List<string> { "JavaScript", "TypeScript" },
            new List<string> { "Vuejs", "Reactjs" },
            new List<string> { "Jest", "Jasmine" },
            new List<string> { "PHP", "Laravel" },
            new List<string> { "Python", "Django" }
        };
        Activities = new List<string>
        {
            "Completed 5 new projects",
            "Updated profile information",
            "Subscribed to a monthly plan",
            "Learned a new programming language"
        };
    }
}
