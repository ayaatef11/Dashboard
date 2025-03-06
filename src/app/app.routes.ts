import { Routes,RouterModule } from '@angular/router';
import { CoursesComponent } from './Components/courses/courses.component';
import { FriendsComponent } from './Components/friends/friends.component';
import { PlansComponent } from './Components/plans/plans.component';
import { ProfileComponent } from './Components/profile/profile.component';
import { ProjectsComponent } from './Components/projects/projects.component';
import { SettingsComponent } from './Components/settings/settings.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { DashboardComponent } from './Components/dashboard/dashboard.component';
import { FilesComponent } from './Components/files/files.component';
import { SidebarComponent } from './Components/sidebar/sidebar.component';

export const routes: Routes = [
  { path: 'courses', component: CoursesComponent },
  { path: 'files', component: FilesComponent },
  { path: 'friends', component: FriendsComponent },
  { path: 'plans', component: PlansComponent },
  { path: 'profile', component: ProfileComponent },
  { path: 'projects', component: ProjectsComponent },
  { path: 'settings', component: SettingsComponent },
  { path: 'sidebar', component: SidebarComponent },
  { path: 'dashboard', component: DashboardComponent }

];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})export class AppRoutingModule { }

