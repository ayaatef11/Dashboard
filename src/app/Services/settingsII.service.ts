import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { SettingsItem } from '../Models/SettingsItem.model';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {
  private apiUrl = 'http://localhost:5275/api/settingsItems'; 

  constructor(private http: HttpClient) {}

  getSettings(): Observable<SettingsItem[]> {
    return this.http.get<SettingsItem[]>(this.apiUrl);
  }

  getSettingById(id: number): Observable<SettingsItem> {
    return this.http.get<SettingsItem>(`${this.apiUrl}/${id}`);
  }

  addSetting(setting: SettingsItem): Observable<SettingsItem> {
    return this.http.post<SettingsItem>(this.apiUrl, setting);
  }

  updateSetting(id: number, setting: SettingsItem): Observable<SettingsItem> {
    return this.http.put<SettingsItem>(`${this.apiUrl}/${id}`, setting);
  }

  deleteSetting(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
