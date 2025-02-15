import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [NgFor],
  templateUrl: './projects.component.html',
  styleUrl: './projects.component.css'
})
export class ProjectsComponent {
  projects = [
    {
      date: '15/6/2022',
      title: 'Ahmed Dashboard',
      description: 'Ahmed Dashboard Project Design And Programming And Hosting',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-03.png', '/imgs/team-04.png'],
      categories: ['Programming', 'Design', 'Hosting', 'Marketing'],
      progress: 60,
      price: 1700
    },
    {
      date: '15/6/2022',
      title: 'Ahmed Portal',
      description: 'Ahmed Portal Project Design And Programming',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-03.png'],
      categories: ['Programming', 'Design'],
      progress: 70,
      price: 850
    },
    {
      date: '15/6/2022',
      title: 'Mohamed Application',
      description: 'Mohamed Application Project Design',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-03.png'],
      categories: ['Design'],
      progress: 40,
      price: 950
    },
    {
      date: '15/6/2022',
      title: 'Mohamed Dashboard',
      description: 'Mohamed Dashboard Project Design And Programming And Hosting',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-03.png', '/imgs/team-04.png'],
      categories: ['Programming', 'Design', 'Hosting', 'Marketing'],
      progress: 65,
      price: 1950
    },
    {
      date: '15/6/2022',
      title: 'Mohamed Portal',
      description: 'Mohamed Portal Project Design And Programming',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-03.png'],
      categories: ['Programming', 'Design'],
      progress: 60,
      price: 1650
    },
    {
      date: '15/6/2022',
      title: 'Ahmed Application',
      description: 'Ahmed Application Project Design',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-03.png'],
      categories: ['Design'],
      progress: 90,
      price: 950
    }
  ];
}
