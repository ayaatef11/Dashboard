export class Target{
  Id:number;
  type:string;
  amount:string;
  icon:string;
  color:string;
  progress:number;
  constructor(Id:number,type:string,amount:string,icon:string,color:string,progress:number){
this.Id=Id;
this.type=type;
this.amount=amount;
this.icon=icon;
this.color=color;
this.progress=progress;

  }

}
