export class File{
Id:number;
name:string;
type:string;
owner:string;
date:Date;
size:string;
constructor(Id:number,name:string, type: string, owner: string, date:Date, size:string){
this.Id=Id;
this.name=name;
this.type=type;
this.owner=owner;
this.date=date;
this.size=size;

}
}
