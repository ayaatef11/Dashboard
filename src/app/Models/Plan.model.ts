import { Feature } from "./Feature.model";

export class Plan{
  Id:number;
name:string;
price:number;
features:Feature[];
  constructor(id:number=0,name:string='',price:number=0, features:Feature[]=[]){
this.Id=id;
    this.name=name;
this.price=price;
this.features=features;
  }
}
