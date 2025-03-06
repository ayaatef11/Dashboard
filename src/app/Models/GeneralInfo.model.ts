export class GeneralInfo{
  label:string;
  type:string;
  id:string;
  placeholder:string;
  value:string;
  disabled:boolean;
  showlink:boolean;

  constructor(label:string,type:string,id:string,placeholder:string,value:string,disabled:boolean,showlink:boolean){
    this.label=label;
    this.type=type;
    this.id=id;
    this.placeholder=placeholder;
    this.value=value;
    this.disabled=disabled;
    this.showlink=showlink;
  }
  
}

