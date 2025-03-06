import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Dashboard } from '../Models/Dashboard';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  private apiUrl = 'http://localhost:5275/api/Dashboards';

  constructor(private http: HttpClient) {}

  getDashboards(): Observable<Dashboard[]> {
    return this.http.get<Dashboard[]>(this.apiUrl);
  }

  getDashboardById(id: number): Observable<Dashboard> {
    return this.http.get<Dashboard>(`${this.apiUrl}/${id}`);
  }

  addDashboard(Dashboard: Dashboard): Observable<Dashboard> {
    return this.http.post<Dashboard>(this.apiUrl, Dashboard);
  }

  updateDashboard(id: number, Dashboard: Dashboard): Observable<Dashboard> {
    return this.http.put<Dashboard>(`${this.apiUrl}/${id}`, Dashboard);
  }

  deleteDashboard(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
