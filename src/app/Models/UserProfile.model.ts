export class UserProfile {
  Id:number=0;///////////////need to modify
  fullName: string;
  gender: string;
  country: string;
  email: string;
  phone: string;
  dateOfBirth: string;
  title: string;
  programmingLanguage: string;
  yearsOfExperience: string;
  paymentMethod: string;
  billingEmail: string;
  subscription: string;
  skills: string[][];
  activities: string[];

  constructor() {
    this.fullName = "Osama Mohamed";
    this.gender = "Male";
    this.country = "Egypt";
    this.email = "o.nn.sa";
    this.phone = "019123456789";
    this.dateOfBirth = "25/10/1982";
    this.title = "Full Stack Developer";
    this.programmingLanguage = "Python";
    this.yearsOfExperience = "15+";
    this.paymentMethod = "Paypal";
    this.billingEmail = "email.website.com";
    this.subscription = "Monthly";
    this.skills = [
      ["HTML", "Pugjs", "HAML"],
      ["CSS", "SASS", "Stylus"],
      ["JavaScript", "TypeScript"],
      ["Vuejs", "Reactjs"],
      ["Jest", "Jasmine"],
      ["PHP", "Laravel"],
      ["Python", "Django"]
    ];
    this.activities = [
      "Completed 5 new projects",
      "Updated profile information",
      "Subscribed to a monthly plan",
      "Learned a new programming language"
    ];
  }
}
