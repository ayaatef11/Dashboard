import { NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Activity } from '../../Models/Activity.model';
import { ProfileService } from '../../Services/ProfileService.service';
import { UserProfile } from '../../Models/UserProfile.model';
import { HeadHeadComponent } from "../../Shared/head-head/head-head.component";

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [NgFor, HeadHeadComponent],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent implements OnInit{
  ngOnInit(): void {
    this.loadActivities();
  }
  userProfile: UserProfile;
  activities :Activity[]=[];

  constructor(private profileService:ProfileService){
  this.userProfile = new UserProfile(); // Initialize with default values
  }
  loadActivities(): void {
    this.profileService.getProfiles().subscribe({
      next: (data) => this.activities = data,
      error: (err) => console.error('Error fetching settings', err)
    });
  }

}
