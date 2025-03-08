import { NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Dashboard } from '../../Models/Dashboard';
import { DashboardService } from '../../Services/DashboardService.service';
import { RouterLink } from '@angular/router';
import { HeadHeadComponent } from "../../Shared/head-head/head-head.component";

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [NgFor, RouterLink, HeadHeadComponent],
  templateUrl: './projects.component.html',
  styleUrl: './projects.component.css'
})
export class ProjectsComponent implements OnInit {
  projects:Dashboard[]=[];

  constructor(private dashboardService:DashboardService ) {

  }

  ngOnInit(): void {
    this.loadDashboards();

 }

 loadDashboards(): void {
   this.dashboardService.getDashboards().subscribe({
     next: (data) => this.projects = data,
     error: (err) => console.error('Error fetching settings', err)
   });
 }

}
