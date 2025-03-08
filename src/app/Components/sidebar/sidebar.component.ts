import { NgClass, NgFor } from '@angular/common';
import { Component, NgModule,OnInit ,inject } from '@angular/core';
import { RouterLink } from '@angular/router';
import { HttpClient , provideHttpClient} from '@angular/common/http';
import { SidebarService } from '../../Services/sidebar.service';
import { Menue } from '../../Models/Menue.model';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [NgFor,RouterLink,NgClass],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent implements OnInit {

  menuItems: Menue[] = []; // Stores the fetched menu items
  // private http:HttpClient = inject(HttpClient); // ✅ Inject HttpClient

   constructor(private sidebarService: SidebarService) {} // Inject HttpClient

  ngOnInit(): void {
    this.getMenuItems();
  }

  getMenuItems(): void {
    this.sidebarService.getMenuItems().subscribe({
      next: (data) => {
        this.menuItems = data;
        console.log('Fetched menu items:', this.menuItems);
      },
      error: (err) => {
        console.error('Error fetching menu items:', err);
      }
    });
  }


  //   this.http.get<any[]>('http://localhost:5275/api/menuitems')

}
