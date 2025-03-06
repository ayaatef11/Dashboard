import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { SettingsItem } from '../Models/SettingsItem.model';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {
  private apiUrl = 'http://localhost:5275/api/settingsItems'; // Update with your backend API URL

  constructor(private http: HttpClient) {}

  // Fetch all settings items
  getSettings(): Observable<SettingsItem[]> {
    return this.http.get<SettingsItem[]>(this.apiUrl);
  }

  // Fetch a single settings item by ID
  getSettingById(id: number): Observable<SettingsItem> {
    return this.http.get<SettingsItem>(`${this.apiUrl}/${id}`);
  }

  // Add a new settings item
  addSetting(setting: SettingsItem): Observable<SettingsItem> {
    return this.http.post<SettingsItem>(this.apiUrl, setting);
  }

  // Update an existing settings item
  updateSetting(id: number, setting: SettingsItem): Observable<SettingsItem> {
    return this.http.put<SettingsItem>(`${this.apiUrl}/${id}`, setting);
  }

  // Delete a settings item
  deleteSetting(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
