import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BackupTime } from '../Models/BackupTime.model';

@Injectable({
  providedIn: 'root'
})
export class BackupTimeService {
  private apiUrl = 'http://localhost:5275/api/BackupTimes';

  constructor(private http: HttpClient) {}

  getTimes(): Observable<BackupTime[]> {
    return this.http.get<BackupTime[]>(this.apiUrl);
  }

  getTimeById(id: number): Observable<BackupTime> {
    return this.http.get<BackupTime>(`${this.apiUrl}/${id}`);
  }

  addTime(backup: BackupTime): Observable<BackupTime> {
    return this.http.post<BackupTime>(this.apiUrl, backup);
  }

  updateTime(id: number, backup: BackupTime): Observable<BackupTime> {
    return this.http.put<BackupTime>(`${this.apiUrl}/${id}`, backup);
  }

  deleteTime(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
