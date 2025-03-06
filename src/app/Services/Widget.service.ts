import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GeneralInfo } from '../Models/GeneralInfo.model';
@Injectable({
  providedIn: 'root'
})
export class WidgetService {
  private apiUrl = 'http://localhost:5275/api/Widget';

  constructor(private http: HttpClient) {}

  getWidget(): Observable<GeneralInfo[]> {
    return this.http.get<GeneralInfo[]>(this.apiUrl);
  }

  getGeneralInfoById(id: number): Observable<GeneralInfo> {
    return this.http.get<GeneralInfo>(`${this.apiUrl}/${id}`);
  }

  addGeneralInfo(GeneralInfo: GeneralInfo): Observable<GeneralInfo> {
    return this.http.post<GeneralInfo>(this.apiUrl, GeneralInfo);
  }

  updateGeneralInfo(id: number, GeneralInfo: GeneralInfo): Observable<GeneralInfo> {
    return this.http.put<GeneralInfo>(`${this.apiUrl}/${id}`, GeneralInfo);
  }

  deleteGeneralInfo(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
