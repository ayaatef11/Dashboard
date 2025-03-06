import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { SocialMedia } from '../Models/SocialMedia.model';
@Injectable({
  providedIn: 'root'
})
export class SocialMediasService {
  private apiUrl = 'http://localhost:5275/api/SocialMedia';

  constructor(private http: HttpClient) {}

  getSocialMedias(): Observable<SocialMedia[]> {
    return this.http.get<SocialMedia[]>(this.apiUrl);
  }

  getSocialMediaById(id: number): Observable<SocialMedia> {
    return this.http.get<SocialMedia>(`${this.apiUrl}/${id}`);
  }

  addSocialMedia(SocialMedia: SocialMedia): Observable<SocialMedia> {
    return this.http.post<SocialMedia>(this.apiUrl, SocialMedia);
  }

  updateSocialMedia(id: number, SocialMedia: SocialMedia): Observable<SocialMedia> {
    return this.http.put<SocialMedia>(`${this.apiUrl}/${id}`, SocialMedia);
  }

  deleteSocialMedia(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
