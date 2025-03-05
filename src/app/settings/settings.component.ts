import { NgClass, NgFor, NgIf } from '@angular/common';
import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-settings',
  standalone: true,
  imports: [NgFor,NgIf,RouterLink,NgClass],
  templateUrl: './settings.component.html',
  styleUrl: './settings.component.css'
})
export class SettingsComponent {


  // menuItems = [
  //   { name: 'Dashboard', icon: 'fa-regular fa-chart-bar', link: 'index' },
  //   { name: 'Settings', icon: 'fa-solid fa-gear', link: 'settings' },
  //   { name: 'Profile', icon: 'fa-regular fa-user', link: 'profile' },
  //   { name: 'Projects', icon: 'fa-solid fa-diagram-project', link: 'projects' },
  //   { name: 'Courses', icon: 'fa-solid fa-graduation-cap', link: 'courses' },
  //   { name: 'Friends', icon: 'fa-regular fa-circle-user', link: 'friends' },
  //   { name: 'Files', icon: 'fa-regular fa-file', link: 'files' },
  //   { name: 'Plans', icon: 'fa-regular fa-credit-card', link: 'plans' }
  // ];

  activeLink = 'settings'; // Set the currently active link



  generalInfo = [
    { label: 'First Name', type: 'text', id: 'first', placeholder: 'First Name', value: '', disabled: false },
    { label: 'Last Name', type: 'text', id: 'last', placeholder: 'Last Name', value: '', disabled: false },
    { label: 'Email', type: 'email', id: 'email', placeholder: 'Email', value: 'o@nn.sa', disabled: true, showLink: true }
  ];




  socialMedia = [
    { id: 'twitter', icon: 'fa-twitter', placeholder: 'Twitter Username' },
    { id: 'facebook', icon: 'fa-facebook-f', placeholder: 'Facebook Username' },
    { id: 'linkedin', icon: 'fa-linkedin', placeholder: 'LinkedIn Username' },
    { id: 'youtube', icon: 'fa-youtube', placeholder: 'YouTube Username' }
  ];

  widgets = [
    { id: 'one', name: 'Quick Draft', checked: true },
    { id: 'two', name: 'Yearly Targets', checked: true },
    { id: 'three', name: 'Tickets Statistics', checked: true },
    { id: 'four', name: 'Latest News', checked: true },
    { id: 'five', name: 'Latest Tasks', checked: false },
    { id: 'six', name: 'Top Search Items', checked: true }
  ];

  backupTimes = [
    { id: 'daily', label: 'Daily', checked: true },
    { id: 'weekly', label: 'Weekly', checked: false },
    { id: 'monthly', label: 'Monthly', checked: false }
  ];

  servers = [
    { id: 'server-one', name: 'Megaman', checked: false },
    { id: 'server-two', name: 'Zero', checked: true },
    { id: 'server-three', name: 'Sigma', checked: false }
  ];
}
