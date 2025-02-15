import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-courses',
  standalone: true,
  imports: [NgFor],
  templateUrl: './courses.component.html',
  styleUrl: './courses.component.css'
})
export class CoursesComponent {
  menuItems = [
    { name: 'Dashboard', icon: 'fa-regular fa-chart-bar', link: '/dashboard' },
    { name: 'Settings', icon: 'fa-solid fa-gear', link: '/settings' },
    { name: 'Profile', icon: 'fa-regular fa-user', link: '/profile' },
    { name: 'Projects', icon: 'fa-solid fa-diagram-project', link: '/projects' },
    { name: 'Courses', icon: 'fa-solid fa-graduation-cap', link: '/courses' },
    { name: 'Friends', icon: 'fa-regular fa-circle-user', link: '/friends' },
    { name: 'Files', icon: 'fa-regular fa-file', link: '/files' },
    { name: 'Plans', icon: 'fa-regular fa-credit-card', link: '/plans' }
  ];

  activeLink = '/courses'; // Set the active link

  courses = [
    {
      title: 'Mastering Web Design',
      description: 'Master The Art Of Web Designing And Mocking, Prototyping And Creating Web Design Architecture',
      cover: '/imgs/course-01.jpg',
      instructor: '/imgs/team-01.png',
      students: 950,
      price: 165
    },
    {
      title: 'Data Structure And Algorithms',
      description: 'Master The Art Of Data Structure And Famous Algorithms Like Sorting, Dividing And Conquering',
      cover: '/imgs/course-02.jpg',
      instructor: '/imgs/team-02.png',
      students: 1150,
      price: 210
    },
    {
      title: 'Responsive Web Design',
      description: 'Mastering Responsive Web Design And Media Queries And Know Everything About Breakpoints',
      cover: '/imgs/course-03.jpg',
      instructor: '/imgs/team-01.png',
      students: 650,
      price: 90
    },
    {
      title: 'Mastering Python',
      description: 'Mastering Python To Prepare For Data Science And AI And Automating Things in Your Life',
      cover: '/imgs/course-04.jpg',
      instructor: '/imgs/team-03.png',
      students: 950,
      price: 250
    },
    {
      title: 'PHP Examples',
      description: 'PHP Tutorials And Examples And Practice On Web Application And Connecting With Databases',
      cover: '/imgs/course-05.jpg',
      instructor: '/imgs/team-03.png',
      students: 850,
      price: 150
    }
  ];

}
