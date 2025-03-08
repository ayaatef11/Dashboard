import { NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Dashboard } from '../../Models/Dashboard';
import { DashboardService } from '../../Services/DashboardService.service';

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [NgFor],
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
