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
  newsItems = [
    {
      image: 'imgs/news-01.png',
      title: 'Created SASS Section',
      description: 'New SASS Examples & Tutorials',
      timeAgo: '3 Days Ago'
    },
    {
      image: 'imgs/news-02.png',
      title: 'Changed The Design',
      description: 'A Brand New Website Design',
      timeAgo: '5 Days Ago'
    },
    {
      image: 'imgs/news-03.png',
      title: 'Team Increased',
      description: '3 Developers Joined The Team',
      timeAgo: '7 Days Ago'
    },
    {
      image: 'imgs/news-04.png',
      title: 'Added Payment Gateway',
      description: 'Many New Payment Gateways Added',
      timeAgo: '9 Days Ago'
    }
  ];

  tasks = [
    { title: 'Record One New Video', description: 'Record Python Create Exe Project', done: false },
    { title: 'Write Article', description: 'Write Low Level vs High Level Languages', done: false },
    { title: 'Finish Project', description: 'Publish Academy Programming Project', done: false },
    { title: 'Attend The Meeting', description: 'Attend The Project Business Analysis Meeting', done: true },
    { title: 'Finish Lesson', description: 'Finish Teaching Flex Box', done: false }
  ];
  
  statuses = [
    { label: 'Total', count: 2500, icon: 'fa-rectangle-list', color: 'orange' },
    { label: 'Pending', count: 500, icon: 'fa-spinner', color: 'blue' },
    { label: 'Closed', count: 1900, icon: 'fa-circle-check', color: 'green' },
    { label: 'Deleted', count: 100, icon: 'fa-rectangle-xmark', color: 'red' }
  ];
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
