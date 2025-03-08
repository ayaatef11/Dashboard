export class Project {
  Id:number;
  name: string;
  finishDate: string;
  client: string;
  price: string;
  team: string[];
  status: {
    text: string;
    class: string;
  };

  constructor(
    id:number,
    name: string,
    finishDate: string,
    client: string,
    price: string,
    team: string[],
    status: { text: string; class: string }
  ) {
    this.Id=id;
    this.name = name;
    this.finishDate = finishDate;
    this.client = client;
    this.price = price;
    this.team = team;
    this.status = status;
  }
}
