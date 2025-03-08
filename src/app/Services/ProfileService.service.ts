import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Activity } from '../Models/Activity.model';
@Injectable({
  providedIn: 'root'
})
export class ProfileService {
  private apiUrl = 'http://localhost:5275/api/Profiles';

  constructor(private http: HttpClient) {}

  getProfiles(): Observable<Activity[]> {
    return this.http.get<Activity[]>(this.apiUrl);
  }

  getProfileById(id: number): Observable<Activity> {
    return this.http.get<Activity>(`${this.apiUrl}/${id}`);
  }

  addProfile(Activity: Activity): Observable<Activity> {
    return this.http.post<Activity>(this.apiUrl, Activity);
  }

  updateProfile(id: number, Activity: Activity): Observable<Activity> {
    return this.http.put<Activity>(`${this.apiUrl}/${id}`, Activity);
  }

  deleteProfile(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
