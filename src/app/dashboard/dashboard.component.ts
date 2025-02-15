import { NgClass, NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [NgFor,NgClass],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
  targets = [
    {
      type: 'Money',
      amount: '$20.000',
      icon: 'fa-dollar-sign',
      color: 'blue',
      progress: 80
    },
    {
      type: 'Projects',
      amount: '24',
      icon: 'fa-code',
      color: 'orange',
      progress: 55
    },
    {
      type: 'Team',
      amount: '12',
      icon: 'fa-user',
      color: 'green',
      progress: 75
    }
  ];
}
