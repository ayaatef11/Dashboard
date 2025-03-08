import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Friend } from '../Models/Friend.model';

@Injectable({
  providedIn: 'root'
})
export class FriendService {
  private apiUrl = 'http://localhost:5275/api/Friends';

  constructor(private http: HttpClient) {}

  getFriends(): Observable<Friend[]> {
    return this.http.get<Friend[]>(this.apiUrl);
  }

  getFriendById(id: number): Observable<Friend> {
    return this.http.get<Friend>(`${this.apiUrl}/${id}`);
  }

  addFriend(Friend: Friend): Observable<Friend> {
    return this.http.post<Friend>(this.apiUrl, Friend);
  }

  updateFriend(id: number, Friend: Friend): Observable<Friend> {
    return this.http.put<Friend>(`${this.apiUrl}/${id}`, Friend);
  }

  deleteFriend(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
