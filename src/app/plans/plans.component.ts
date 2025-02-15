import { Component } from '@angular/core';
import { SidebarComponent } from "../sidebar/sidebar.component";

@Component({
  selector: 'app-plans',
  standalone: true,
  imports: [SidebarComponent],
  templateUrl: './plans.component.html',
  styleUrl: './plans.component.css'
})
export class PlansComponent {

}
