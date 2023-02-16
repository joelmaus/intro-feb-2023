import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LearningResourcesComponent } from './learning-resources.component';
import { RouterModule, Routes } from '@angular/router';
import { NewComponent } from './components/new/new.component';
import { StoreModule } from '@ngrx/store';
import { featureName , reducers} from './state';


const routes: Routes = [
  {
    path: '',
    component: LearningResourcesComponent
  }
]

@NgModule({
  declarations: [
    LearningResourcesComponent,
    NewComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    StoreModule.forFeature(featureName, reducers)
  ]
})
export class LearningResourcesModule { }
