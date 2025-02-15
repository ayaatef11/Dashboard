import { Component } from '@angular/core';
import { SidebarComponent } from "../sidebar/sidebar.component";

@Component({
  selector: 'app-files',
  standalone: true,
  imports: [SidebarComponent],
  templateUrl: './files.component.html',
  styleUrl: './files.component.css'
})
export class FilesComponent {

}
