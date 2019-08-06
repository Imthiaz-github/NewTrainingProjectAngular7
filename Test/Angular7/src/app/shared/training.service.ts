import { Injectable } from '@angular/core';
import { Training } from './training.model';
import{ HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class TrainingService {
  formData : Training;
readonly rootURL = "http://localhost:61482/api";

  constructor(private http: HttpClient) { }

  postTraining(formData: Training){
return this.http.post(this.rootURL+'/Training', formData);
  }
  error:any={isError:false,errorMessage:''};

}
