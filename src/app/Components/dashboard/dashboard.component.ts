import { NgClass, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { ProjectService } from '../../Services/ProjectService.Service';
import { Project } from '../../Models/Project.model';
import { NewItem } from '../../Models/NewItem.model';
import { Task } from '../../Models/Task.model';
import { Keyword } from '../../Models/Keyword.model';
import { SocialMedia } from '../../Models/SocialMedia.model';
import { Status } from '../../Models/Status.model';
import { Target } from '../../Models/Target.model';
import { RouterLink } from '@angular/router';
import { SocialPlatform } from '../../Models/SocialPlatform.model';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [NgFor,NgClass,RouterLink],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
    projects:Project[]=[];

    constructor(private projectService:ProjectService ) {

    }
  newsItems:NewItem[] =[];

  tasks:Task[] =[];

  keywords:Keyword[] =[];

  files = [
    { name: 'my-file.pdf', type: 'Client', size: '2.9mb', icon: 'imgs/pdf.svg' },
    { name: 'My-Video-File.avi', type: 'Admin', size: '4.9mb', icon: 'imgs/avi.svg' },
    { name: 'My-Psd-File.pdf', type: 'Client', size: '4.5mb', icon: 'imgs/psd.svg' },
    { name: 'My-Zip-File.pdf', type: 'User', size: '8.9mb', icon: 'imgs/zip.svg' },
    { name: 'My-DLL-File.pdf', type: 'Admin', size: '4.9mb', icon: 'imgs/dll.svg' },
    { name: 'My-Eps-File.pdf', type: 'Designer', size: '8.9mb', icon: 'imgs/eps.svg' }
  ];

  socialPlatforms:SocialPlatform[] =[];

  statuses :Status[]=[];
  targets:Target[] =[];
}
