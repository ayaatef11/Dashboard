// import { Injectable } from '@angular/core';
// import { HttpClient } from '@angular/common/http';
// import { Observable } from 'rxjs';
// import { Plan } from '../Models/Plan.model';
// @Injectable({
//   providedIn: 'root'
// })
// export class PlanService {
//   private apiUrl = 'http://localhost:5275/api/Plans';

//   constructor(private http: HttpClient) {}

//   getPlans(): Observable<Plan[]> {
//     return this.http.get<Plan[]>(this.apiUrl);
//   }

//   getPlanById(id: number): Observable<Plan> {
//     return this.http.get<Plan>(`${this.apiUrl}/${id}`);
//   }

//   addPlan(Plan: Plan): Observable<Plan> {
//     return this.http.post<Plan>(this.apiUrl, Plan);
//   }

//   updatePlan(id: number, Plan: Plan): Observable<Plan> {
//     return this.http.put<Plan>(`${this.apiUrl}/${id}`, Plan);
//   }

//   deletePlan(id: number): Observable<void> {
//     return this.http.delete<void>(`${this.apiUrl}/${id}`);
//   }
// }
