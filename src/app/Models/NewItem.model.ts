export class NewItem {
  Id:number;
  image: string;
  title: string;
  description: string;
  timeAgo: string;

  constructor(id:number,image: string, title: string, description: string, timeAgo: string) {
    this.Id=id;
    this.image = image;
    this.title = title;
    this.description = description;
    this.timeAgo = timeAgo;
  }
}
