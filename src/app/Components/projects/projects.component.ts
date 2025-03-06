import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { Dashboard } from '../../Models/Dashboard';
import { DashboardService } from '../../Services/DashboardService.service';

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [NgFor],
  templateUrl: './projects.component.html',
  styleUrl: './projects.component.css'
})
export class ProjectsComponent implements ngOnInit {
  projects:Dashboard[]=[];

  constructor(private dashboardService:DashboardService ) {

  }
}
