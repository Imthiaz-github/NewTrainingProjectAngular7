import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from "@angular/forms";
import{ HttpClientModule } from "@angular/common/http";
import { AppComponent } from './app.component';
import { TrainingsComponent } from './trainings/trainings.component';
import { TrainingComponent } from './trainings/training/training.component';
import { TrainingListComponent } from './trainings/training-list/training-list.component';
import { TrainingService } from './shared/training.service';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [
    AppComponent,
    TrainingsComponent,
    TrainingComponent,
    TrainingListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    BsDatepickerModule.forRoot(),
    BrowserAnimationsModule,
    HttpClientModule
  ],
  providers: [TrainingService],
  bootstrap: [AppComponent]
})
export class AppModule { }
