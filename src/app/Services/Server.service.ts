import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Server } from '../Models/Server.model';
@Injectable({
  providedIn: 'root'
})
export class ServersService {
  private apiUrl = 'http://localhost:5275/api/Server';

  constructor(private http: HttpClient) {}

  getServers(): Observable<Server[]> {
    return this.http.get<Server[]>(this.apiUrl);
  }

  getServerById(id: number): Observable<Server> {
    return this.http.get<Server>(`${this.apiUrl}/${id}`);
  }

  addServer(Server: Server): Observable<Server> {
    return this.http.post<Server>(this.apiUrl, Server);
  }

  updateServer(id: number, Server: Server): Observable<Server> {
    return this.http.put<Server>(`${this.apiUrl}/${id}`, Server);
  }

  deleteServer(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
