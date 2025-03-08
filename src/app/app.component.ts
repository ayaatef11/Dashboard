import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { RouterModule } from '@angular/router';
import { SidebarComponent } from './Components/sidebar/sidebar.component';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [SidebarComponent,RouterOutlet,ReactiveFormsModule]
})
export class AppComponent {
  title = 'Dashboard';
}
