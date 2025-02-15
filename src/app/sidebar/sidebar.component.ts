import { NgClass, NgFor } from '@angular/common';
import { Component, NgModule } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [NgFor,RouterLink,NgClass],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent {
  menuItems = [
    { path: '/dashboard', icon: 'fa-chart-bar', label: 'Dashboard' },
    { path: '/settings', icon: 'fa-gear', label: 'Settings' },
    { path: '/profile', icon: 'fa-user', label: 'Profile' },
    { path: '/projects', icon: 'fa-diagram-project', label: 'Projects' },
    { path: '/courses', icon: 'fa-graduation-cap', label: 'Courses' },
    { path: '/friends', icon: 'fa-circle-user', label: 'Friends' },
    { path: '/files', icon: 'fa-file', label: 'Files' },
    { path: '/plans', icon: 'fa-credit-card', label: 'Plans' },
  ];
}
