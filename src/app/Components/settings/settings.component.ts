import { NgClass, NgFor, NgIf } from '@angular/common';
import { Component,OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { SettingsService } from '../../Services/settingsII.service';
import { SettingsItem } from '../../Models/SettingsItem.model';
import { GeneralInfo } from '../../Models/GeneralInfo.model';
import { GeneralInfosService } from '../../Services/GeneralInfo.service';
import { SocialMedia } from '../../Models/SocialMedia.model';
import { SocialMediasService } from '../../Services/SocialMedia.service';
import { Widget } from '../../Models/Widget.model';
import { WidgetService } from '../../Services/Widget.service';
import { BackupTime } from '../../Models/BackupTime.model';
import { Server } from '../../Models/Server.model';
import { BackupTimeService } from '../../Services/BackupTime.service';
import { ServersService } from '../../Services/Server.service';
import { HeadHeadComponent } from "../../Shared/head-head/head-head.component";
@Component({
  selector: 'app-settings',
  standalone: true,
  imports: [NgFor, NgIf, NgClass, HeadHeadComponent],
  templateUrl: './settings.component.html',
  styleUrl: './settings.component.css'
})
export class SettingsComponent implements OnInit {
//call the models
  settings: SettingsItem[] = [];
  generalInfo: GeneralInfo[] = [];
  socialMedia: SocialMedia[] = [];
  widgets:Widget[]=[];
  backupTimes:BackupTime[]=[];
  servers:Server[]=[];
  //call the services
  constructor(private settingsService: SettingsService,private generalInfoService:GeneralInfosService
    ,private socialMedias:SocialMediasService,private widgetServices:WidgetService
  ,private backupService:BackupTimeService, private ServerServices: ServersService) {}

  ngOnInit(): void {
     this.loadSettings();
     this.loadGenralInfos();

  }

  loadSettings(): void {
    this.settingsService.getSettings().subscribe({
      next: (data) => this.settings = data,
      error: (err) => console.error('Error fetching settings', err)
    });
  }

loadGenralInfos():void{
  this.generalInfoService.getGeneralInfos().subscribe({
    next:(data)=>this.generalInfo=data,
    error:(err)=>console.error("Error fetching infos",err)
  });
}

loadWidgets():void{
this.widgetServices.getWidgets().subscribe({
  next:(data)=>this.widgets=data,
  error:(err)=>console.error('Error fetching medias',err)
});
}

loadSocialMedias():void{
  this.socialMedias.getSocialMedias().subscribe({
    next:(data)=>this.socialMedia=data,
    error:(err)=>console.error('Error fetching medias',err)
  });
}


loadBackupTimes():void{
  this.backupService.getTimes().subscribe({
    next:(data)=>this.backupTimes=data,
    error:(err)=>console.error('Error fetching medias',err)
  });
}



loadServers():void{
  this.ServerServices.getServers().subscribe({
    next:(data)=>this.servers=data,
    error:(err)=>console.error('Error fetching medias',err)
  });
}

  activeLink = 'settings'; // Set the currently active link



  // generalInfo = [
  //   { label: 'First Name', type: 'text', id: 'first', placeholder: 'First Name', value: '', disabled: false },
  //   { label: 'Last Name', type: 'text', id: 'last', placeholder: 'Last Name', value: '', disabled: false },
  //   { label: 'Email', type: 'email', id: 'email', placeholder: 'Email', value: 'o@nn.sa', disabled: true, showLink: true }
  // ];




  // socialMedia = [
  //   { id: 'twitter', icon: 'fa-twitter', placeholder: 'Twitter Username' },
  //   { id: 'facebook', icon: 'fa-facebook-f', placeholder: 'Facebook Username' },
  //   { id: 'linkedin', icon: 'fa-linkedin', placeholder: 'LinkedIn Username' },
  //   { id: 'youtube', icon: 'fa-youtube', placeholder: 'YouTube Username' }
  // ];

  // widgets = [
  //   { id: 'one', name: 'Quick Draft', checked: true },
  //   { id: 'two', name: 'Yearly Targets', checked: true },
  //   { id: 'three', name: 'Tickets Statistics', checked: true },
  //   { id: 'four', name: 'Latest News', checked: true },
  //   { id: 'five', name: 'Latest Tasks', checked: false },
  //   { id: 'six', name: 'Top Search Items', checked: true }
  // ];

  // backupTimes = [
  //   { id: 'daily', label: 'Daily', checked: true },
  //   { id: 'weekly', label: 'Weekly', checked: false },
  //   { id: 'monthly', label: 'Monthly', checked: false }
  // ];

  // servers = [
  //   { id: 'server-one', name: 'Megaman', checked: false },
  //   { id: 'server-two', name: 'Zero', checked: true },
  //   { id: 'server-three', name: 'Sigma', checked: false }
  // ];
}
