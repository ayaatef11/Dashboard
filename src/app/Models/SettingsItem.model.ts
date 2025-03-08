export class SettingsItem {
  Id: number;
  name: string;
  icon: string;
  link: string;

  constructor(id: number, name: string = '', icon: string = '', link: string = '') {
    this.Id = id;
    this.name = name;
    this.icon = icon;
    this.link = link;
  }
}
