import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Menue } from '../Models/Menue.model';

@Injectable({
  providedIn: 'root',
})
export class SidebarService {
  private apiUrl = 'http://localhost:5275/api/menuitems';

  constructor(private http: HttpClient) {}

  getMenuItems(): Observable<Menue[]> {
    return this.http.get<Menue[]>(this.apiUrl);
  }

  addMenuItem(menuItem: Menue): Observable<Menue> {
    return this.http.post<Menue>(this.apiUrl, menuItem);
  }

  updateMenuItem(id: number, menuItem: Menue): Observable<Menue> {
    return this.http.put<Menue>(`${this.apiUrl}/${id}`, menuItem);
  }

  deleteMenuItem(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
