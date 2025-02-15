import { Component } from '@angular/core';
import { SidebarComponent } from "../sidebar/sidebar.component";
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-files',
  standalone: true,
  imports: [NgFor],
  templateUrl: './files.component.html',
  styleUrl: './files.component.css'
})
export class FilesComponent {
  fileCategories = [
    { name: 'PDF Files', count: 130, size: '6.5GB', icon: 'fa-file-pdf', color: 'c-red' },
    { name: 'Images', count: 115, size: '3.5GB', icon: 'fa-images', color: 'c-green' },
    { name: 'Word Files', count: 110, size: '3.2GB', icon: 'fa-file-word', color: 'c-blue' },
    { name: 'CSV Files', count: 99, size: '2.9GB', icon: 'fa-file-csv', color: 'c-orange' },
  ];
  
  files = [
    { name: 'my-file.pdf', type: 'pdf', owner: 'Elzero', date: '20/06/2020', size: '5.5MB' },
    { name: 'my-file.avi', type: 'avi', owner: 'Admin', date: '16/5/2021', size: '12.5MB' },
    { name: 'my-file.eps', type: 'eps', owner: 'Uploader', date: '16/5/2021', size: '2.7MB' },
    { name: 'my-file.psd', type: 'psd', owner: 'Osama', date: '16/5/2021', size: '15.1MB' },
    { name: 'my-file.dll', type: 'dll', owner: 'Coder', date: '16/5/2021', size: '2.2MB' },
    { name: 'my-file.png', type: 'png', owner: 'Designer', date: '16/5/2021', size: '1.1MB' }
  ];
}
