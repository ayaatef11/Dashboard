import { Routes,RouterModule } from '@angular/router';
import { CoursesComponent } from './courses/courses.component';
import { FilesComponent } from './files/files.component';
import { FriendsComponent } from './friends/friends.component';
import { PlansComponent } from './plans/plans.component';
import { ProfileComponent } from './profile/profile.component';
import { ProjectsComponent } from './projects/projects.component';
import { SettingsComponent } from './settings/settings.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';

export const routes: Routes = [
  { path: 'courses', component: CoursesComponent },
  { path: 'files', component: FilesComponent },
  { path: 'friends', component: FriendsComponent },
  { path: 'plans', component: PlansComponent },
  { path: 'profile', component: ProfileComponent },
  { path: 'projects', component: ProjectsComponent },
  { path: 'settings', component: SettingsComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})export class AppRoutingModule { }

