export class Task {
  Id:number;
  title: string;
  description: string;
  done: boolean;

  constructor(id:number,title: string, description: string, done: boolean) {
    this.Id=id;
    this.title = title;
    this.description = description;
    this.done = done;
  }
}
