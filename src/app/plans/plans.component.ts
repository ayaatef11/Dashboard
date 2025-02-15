import { Component } from '@angular/core';
import { SidebarComponent } from "../sidebar/sidebar.component";
import { NgClass, NgFor } from '@angular/common';

@Component({
  selector: 'app-plans',
  standalone: true,
  imports: [NgFor,NgClass],
  templateUrl: './plans.component.html',
  styleUrl: './plans.component.css'
})
export class PlansComponent {
  features = [
    { text: 'Access All Text Lessons', available: true },
    { text: 'Access All Videos Lessons', available: true },
    { text: 'Appear On Leaderboard', available: true },
    { text: 'Browse Content Without Ads', available: false },
    { text: 'Access All Assignments', available: false },
    { text: 'Get Daily Prizes', available: false },
    { text: 'Earn Certificate', available: false },
    { text: '1 GB Space For Hosting Files', available: false },
    { text: 'Access Badge System', available: false }
  ];
  plan = {
    name: 'Premium',
    price: 19.99,
    features: [
      'Access All Text Lessons',
      'Access All Videos Lessons',
      'Appear On Leaderboard',
      'Browse Content Without Ads',
      'Access All Assignments',
      'Get Daily Prizes',
      'Earn Certificate',
      '1 GB Space For Hosting Files',
      'Access Badge System'
    ]
  };

}
