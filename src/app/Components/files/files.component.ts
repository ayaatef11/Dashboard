import { Component, OnInit } from '@angular/core';
import { SidebarComponent } from "../sidebar/sidebar.component";
import { NgFor } from '@angular/common';
import { File } from '../../Models/File.model';
import { FileCategory } from '../../Models/FileCategory.model';
import { FilesService } from '../../Services/FilesService.service';

@Component({
  selector: 'app-files',
  standalone: true,
  imports: [NgFor],
  templateUrl: './files.component.html',
  styleUrl: './files.component.css'
})
export class FilesComponent implements OnInit{
  fileCategories :FileCategory[]=[];

  files :File[]=[];
  constructor(private filesService: FilesService){}
  ngOnInit(): void {
this.loadFiles();
  }
loadFiles(){

  this.filesService.getFiles().subscribe({
    next: (data) => this.files = data,
    error: (err) => console.error('Error fetching settings', err)
  });

}
}
