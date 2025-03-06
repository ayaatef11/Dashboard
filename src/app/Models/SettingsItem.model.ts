export class SettingsItem {
  id: number;
  name: string;
  icon: string;
  link: string;

  constructor(id: number, name: string = '', icon: string = '', link: string = '') {
    this.id = id;
    this.name = name;
    this.icon = icon;
    this.link = link;
  }
}
