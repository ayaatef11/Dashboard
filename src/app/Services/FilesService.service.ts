import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { File } from '../Models/File.model';
@Injectable({
  providedIn: 'root'
})
export class FilesService {
  private apiUrl = 'http://localhost:5275/api/Files';

  constructor(private http: HttpClient) {}

  getFiles(): Observable<File[]> {
    return this.http.get<File[]>(this.apiUrl);
  }

  getFileById(id: number): Observable<File> {
    return this.http.get<File>(`${this.apiUrl}/${id}`);
  }

  addFile(File: File): Observable<File> {
    return this.http.post<File>(this.apiUrl, File);
  }

  updateFile(id: number, File: File): Observable<File> {
    return this.http.put<File>(`${this.apiUrl}/${id}`, File);
  }

  deleteFile(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
