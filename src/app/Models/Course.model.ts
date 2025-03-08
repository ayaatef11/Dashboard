export class Course{

  title:string;
  description:string;
  cover:string;
  instructor:string;
  students:number;
  price:number;
  constructor(title:string,description:string,cover:string,instructor:string,students:number,price:number){
this.title=title;
this.description=description;
this.cover=cover;
this.instructor=instructor;
this.students=students;
this.price=price;
  }
}
