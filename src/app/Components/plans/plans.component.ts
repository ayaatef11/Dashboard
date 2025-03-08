import { Component, OnInit } from '@angular/core';
import { NgClass, NgFor } from '@angular/common';
import { Plan } from '../../Models/Plan.model';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-plans',
  standalone: true,
  imports: [NgFor,NgClass],
  templateUrl: './plans.component.html',
  styleUrl: './plans.component.css'
})
export class PlansComponent implements OnInit{

  // Define the plan object with features included
   plan :Plan=new Plan();//[]=[];
   constructor(private http: HttpClient){}//private planService:PlanService){}
   private apiUrl = 'http://localhost:5275/api/Plans';
  ngOnInit(): void {
   //this.loadPlans();
     this.http.get<Plan[]>(this.apiUrl);
  }
  // loadPlans():void{
  //   this.planService.getPlans().subscribe({
  //     next: (data) => this.plan = data,
  //     error: (err) => console.error('Error fetching settings', err)
  //   });
  }

