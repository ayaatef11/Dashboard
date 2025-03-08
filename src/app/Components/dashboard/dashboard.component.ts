import { NgClass, NgFor, NgIf } from '@angular/common';
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
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HeadHeadComponent } from '../../Shared/head-head/head-head.component';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [NgFor,NgClass,RouterLink,NgIf,HeadHeadComponent],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
    projects:Project[]=[];
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

    customForm: FormGroup;


    constructor(private projectService:ProjectService,private fb: FormBuilder ) {
      this.customForm =  this.fb.group({
        title: ['', Validators.required],
        thought:['', [Validators.required, Validators.minLength(5)]]
      });
    }

  submitForm() {
    if (this.customForm.valid) {
      console.log('Form Submitted', this.customForm.value);
    }else{
      console.log("Form is invalid")
    }
  }
}
