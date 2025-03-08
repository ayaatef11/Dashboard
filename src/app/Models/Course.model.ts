export class Course{
  Id:number;
  title:string;
  description:string;
  cover:string;
  instructor:string;
  students:number;
  price:number;
  constructor(id:number,title:string,description:string,cover:string,instructor:string,students:number,price:number){
this.Id=id;
    this.title=title;
this.description=description;
this.cover=cover;
this.instructor=instructor;
this.students=students;
this.price=price;
  }
}
