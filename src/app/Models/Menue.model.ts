export class MenuItem {
  id: number;       // Unique identifier
  path?: string;     // Menu item name
  label?: string; // Category (e.g., Drinks, Food)
  icon?:string;
  constructor(
    id: number,
    path?: string,    // Menu item name
  label?: string,
  icon?:string
  ) {
    this.id = id;
    this.path=path;
    this.icon=icon;
    this.label=label;
  }
}
