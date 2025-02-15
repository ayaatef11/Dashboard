import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [NgFor],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent {
  activities = [
    {
      image: '/imgs/activity-01.png',
      title: 'Store',
      description: 'Bought The Mastering Python Course',
      time: '18:10',
      date: 'Yesterday'
    },
    {
      image: '/imgs/activity-02.png',
      title: 'Academy',
      description: 'Got The PHP Certificate',
      time: '16:05',
      date: 'Yesterday'
    },
    {
      image: '/imgs/activity-03.png',
      title: 'Badges',
      description: 'Unlocked The 10 Skills Badge',
      time: '18:05',
      date: 'Yesterday'
    },
    {
      image: '/imgs/activity-01.png',
      title: 'Store',
      description: 'Bought The Typescript Course',
      time: '12:05',
      date: 'Yesterday'
    }
  ];


}
