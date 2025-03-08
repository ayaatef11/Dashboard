import { Feature } from "./Feature.model";

export class Plan{
name:string;
price:number;
features:Feature[];
  constructor(name:string='',price:number=0, features:Feature[]=[]){
this.name=name;
this.price=price;
this.features=features;
  }
}
