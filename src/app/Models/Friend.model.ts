
export class Friend
{
  constructor(Id:number,name:string,role:string,image:string,friendsCount:number,
    projects:number,articles:number,joined:Date,isvip:boolean
  ){
         this.id=Id;
         this.name=name;
         this.role=role;
         this.image=image;
         this.friendsCount=friendsCount;
         this.projects=projects;
         this.articles=articles;
         this.joined=joined;
         this.isVip=isvip;
  }

  id:number;
  name:string;
  role:string;
  image:string;
  friendsCount:number;
  projects:number;
  articles:number;
  joined:Date;
  isVip:boolean;

}
