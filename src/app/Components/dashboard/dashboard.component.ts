import { NgClass, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { ProjectService } from '../../Services/ProjectService.Service';
import { Project } from '../../Models/Project.model';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [NgFor,NgClass],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
    projects:Project[]=[];

    constructor(private projectService:ProjectService ) {

    }
  newsItems =

  tasks =

  keywords =

  files = [
    { name: 'my-file.pdf', type: 'Client', size: '2.9mb', icon: 'imgs/pdf.svg' },
    { name: 'My-Video-File.avi', type: 'Admin', size: '4.9mb', icon: 'imgs/avi.svg' },
    { name: 'My-Psd-File.pdf', type: 'Client', size: '4.5mb', icon: 'imgs/psd.svg' },
    { name: 'My-Zip-File.pdf', type: 'User', size: '8.9mb', icon: 'imgs/zip.svg' },
    { name: 'My-DLL-File.pdf', type: 'Admin', size: '4.9mb', icon: 'imgs/dll.svg' },
    { name: 'My-Eps-File.pdf', type: 'Designer', size: '8.9mb', icon: 'imgs/eps.svg' }
  ];

  socialPlatforms =

  statuses =
  targets:Target[] =[];
}
