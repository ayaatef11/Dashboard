import { Component } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';
import { RouterLink } from '@angular/router';
import { Friend } from '../../Models/Friend.model';

@Component({
  selector: 'app-friends',
  standalone: true,
  imports: [NgFor,RouterLink,NgIf],
  templateUrl: './friends.component.html',
  styleUrl: './friends.component.css'
})
export class FriendsComponent {
  friends:Friend[]=[];

  removeFriend(id: number) {
    this.friends = this.friends.filter(friend => friend.id !== id);
  }
}
