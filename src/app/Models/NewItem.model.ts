export class NewItem {
  image: string;
  title: string;
  description: string;
  timeAgo: string;

  constructor(image: string, title: string, description: string, timeAgo: string) {
    this.image = image;
    this.title = title;
    this.description = description;
    this.timeAgo = timeAgo;
  }
}
