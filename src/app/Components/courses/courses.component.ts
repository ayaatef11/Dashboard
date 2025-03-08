import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { Menue } from '../../Models/Menue.model';
import { Course } from '../../Models/Course.model';

@Component({
  selector: 'app-courses',
  standalone: true,
  imports: [NgFor],
  templateUrl: './courses.component.html',
  styleUrl: './courses.component.css'
})
export class CoursesComponent {
  menuItems:Menue[]=[];//get it using the api

  activeLink = '/courses';

  courses:Course[] =[];//create the api

}
