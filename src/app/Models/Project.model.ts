export class Project {
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
    name: string,
    finishDate: string,
    client: string,
    price: string,
    team: string[],
    status: { text: string; class: string }
  ) {
    this.name = name;
    this.finishDate = finishDate;
    this.client = client;
    this.price = price;
    this.team = team;
    this.status = status;
  }
}
