import { NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Activity } from '../../Models/Activity.model';
import { ProfileService } from '../../Services/ProfileService.service';

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [NgFor],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent implements OnInit{
  ngOnInit(): void {
    this.loadActivities();
  }

  constructor(private profileService:ProfileService){}
  activities :Activity[]=[];

  loadActivities(): void {
    this.profileService.getProfiles().subscribe({
      next: (data) => this.activities = data,
      error: (err) => console.error('Error fetching settings', err)
    });
  }

}
