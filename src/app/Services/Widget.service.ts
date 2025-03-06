import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Widget } from '../Models/Widget.model';
@Injectable({
  providedIn: 'root'
})
export class WidgetService {
  private apiUrl = 'http://localhost:5275/api/Widget';

  constructor(private http: HttpClient) {}

  getWidgets(): Observable<Widget[]> {
    return this.http.get<Widget[]>(this.apiUrl);
  }

  getWidgetById(id: number): Observable<Widget> {
    return this.http.get<Widget>(`${this.apiUrl}/${id}`);
  }

  addWidget(Widget: Widget): Observable<Widget> {
    return this.http.post<Widget>(this.apiUrl, Widget);
  }

  updateWidget(id: number, Widget: Widget): Observable<Widget> {
    return this.http.put<Widget>(`${this.apiUrl}/${id}`, Widget);
  }

  deleteWidget(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
