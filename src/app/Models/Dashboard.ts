export class Dashboard{
  Id:number;
  data:string;
  title:string;
  description:string;
  team:string;
  categories:string[];
  progress:string;
  price:number;
//use it to define the properities
  constructor(Id:number,data:string,title:string,description:string,team:string,categories:string[],progress:string,price:number){
      this.Id=Id;
      this.data=data;
      this.title=title;
      this.description=description;
      this.team=team;
      this.categories=categories;
      this.progress=progress;
      this.price=price;
  }
}
