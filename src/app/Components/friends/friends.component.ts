import { Component, OnInit } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';
import { RouterLink } from '@angular/router';
import { Friend } from '../../Models/Friend.model';
import { FriendService } from '../../Services/FriendsService.service';
import { HeadHeadComponent } from "../../Shared/head-head/head-head.component";

@Component({
  selector: 'app-friends',
  standalone: true,
  imports: [NgFor, RouterLink, NgIf, HeadHeadComponent],
  templateUrl: './friends.component.html',
  styleUrl: './friends.component.css'
})
export class FriendsComponent implements OnInit{
  friends:Friend[]=[];

  removeFriend(id: number) {
    this.friends = this.friends.filter(friend => friend.id !== id);
  }

  constructor(private friendsService:FriendService){

  }
  ngOnInit(): void {
   this.loadFriends();
  }

  loadFriends(){
    this.friendsService.getFriends().subscribe({
      next: (data) => this.friends = data,
      error: (err) => console.error('Error fetching settings', err)
    });
  }
}
