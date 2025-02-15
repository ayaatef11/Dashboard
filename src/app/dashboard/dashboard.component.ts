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

  keywords = [
    { name: 'Programming', count: 220 },
    { name: 'JavaScript', count: 180 },
    { name: 'PHP', count: 160 },
    { name: 'Code', count: 145 },
    { name: 'Design', count: 110 },
    { name: 'Logic', count: 95 }
  ];

  files = [
    { name: 'my-file.pdf', type: 'Client', size: '2.9mb', icon: 'imgs/pdf.svg' },
    { name: 'My-Video-File.avi', type: 'Admin', size: '4.9mb', icon: 'imgs/avi.svg' },
    { name: 'My-Psd-File.pdf', type: 'Client', size: '4.5mb', icon: 'imgs/psd.svg' },
    { name: 'My-Zip-File.pdf', type: 'User', size: '8.9mb', icon: 'imgs/zip.svg' },
    { name: 'My-DLL-File.pdf', type: 'Admin', size: '4.9mb', icon: 'imgs/dll.svg' },
    { name: 'My-Eps-File.pdf', type: 'Designer', size: '8.9mb', icon: 'imgs/eps.svg' }
  ];

  socialPlatforms = [
    { name: 'Twitter', icon: 'fa-twitter', followers: '90K Followers', action: 'Follow', class: 'twitter' },
    { name: 'Facebook', icon: 'fa-facebook-f', followers: '2M Likes', action: 'Like', class: 'facebook' },
    { name: 'YouTube', icon: 'fa-youtube', followers: '1M Subs', action: 'Subscribe', class: 'youtube' },
    { name: 'LinkedIn', icon: 'fa-linkedin', followers: '70K Followers', action: 'Follow', class: 'linkedin' }
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
  projects = [
    {
      name: 'Ministry Wikipedia',
      finishDate: '10 May 2022',
      client: 'Ministry',
      price: '$5300',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-03.png', '/imgs/team-05.png'],
      status: { text: 'Pending', class: 'bg-orange' }
    },
    {
      name: 'Elzero Shop',
      finishDate: '12 Oct 2021',
      client: 'Elzero Company',
      price: '$1500',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-05.png'],
      status: { text: 'In Progress', class: 'bg-blue' }
    },
    {
      name: 'Bouba App',
      finishDate: '05 Sep 2021',
      client: 'Bouba',
      price: '$800',
      team: ['/imgs/team-02.png', '/imgs/team-03.png'],
      status: { text: 'Completed', class: 'bg-green' }
    },
    {
      name: 'Mahmoud Website',
      finishDate: '22 May 2021',
      client: 'Mahmoud',
      price: '$600',
      team: ['/imgs/team-01.png', '/imgs/team-02.png'],
      status: { text: 'Completed', class: 'bg-green' }
    },
    {
      name: 'Sayed Website',
      finishDate: '24 May 2021',
      client: 'Sayed',
      price: '$300',
      team: ['/imgs/team-01.png', '/imgs/team-03.png'],
      status: { text: 'Rejected', class: 'bg-red' }
    },
    {
      name: 'Arena Application',
      finishDate: '01 Mar 2021',
      client: 'Arena Company',
      price: '$2600',
      team: ['/imgs/team-01.png', '/imgs/team-02.png', '/imgs/team-03.png', '/imgs/team-04.png'],
      status: { text: 'Completed', class: 'bg-green' }
    }
  ];
  
}
