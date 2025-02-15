import { Component } from '@angular/core';
import { SidebarComponent } from "../sidebar/sidebar.component";
import { NgFor, NgIf } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-friends',
  standalone: true,
  imports: [NgFor,RouterLink,NgIf],
  templateUrl: './friends.component.html',
  styleUrl: './friends.component.css'
})
export class FriendsComponent {
  friends = [
    {
      id: 1,
      name: 'Ahmed Nasser',
      role: 'JavaScript Developer',
      image: '/imgs/friend-01.jpg',
      friendsCount: 99,
      projects: 15,
      articles: 25,
      joined: '02/10/2021',
      isVip: true
    },
    {
      id: 2,
      name: 'Omar Fathy',
      role: 'Cloud Developer',
      image: '/imgs/friend-02.jpg',
      friendsCount: 30,
      projects: 11,
      articles: 12,
      joined: '02/08/2020',
      isVip: false
    },
    {
      id: 3,
      name: 'Omar Ahmed',
      role: 'Mobile Developer',
      image: '/imgs/friend-03.jpg',
      friendsCount: 80,
      projects: 20,
      articles: 18,
      joined: '02/06/2020',
      isVip: false
    }
  ];

  removeFriend(id: number) {
    this.friends = this.friends.filter(friend => friend.id !== id);
  }
}
