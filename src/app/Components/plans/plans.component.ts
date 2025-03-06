import { Component } from '@angular/core';
import { SidebarComponent } from "../../sidebar/sidebar.component";
import { NgClass, NgFor } from '@angular/common';
import { Plan } from '../../Models/Plan.model';

@Component({
  selector: 'app-plans',
  standalone: true,
  imports: [NgFor,NgClass],
  templateUrl: './plans.component.html',
  styleUrl: './plans.component.css'
})
export class PlansComponent {

  // Define the plan object with features included
   plan :Plan;
}
