import { Component, OnInit } from '@angular/core';
import { TrainingService } from 'src/app/shared/training.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-training',
  templateUrl: './training.component.html',
  styleUrls: ['./training.component.css']
})
export class TrainingComponent implements OnInit {
  showMsg: boolean = false;

  constructor(private service: TrainingService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm){
    if(form !=null)
   form.resetForm();
   this.service.formData={
     TrainingID:null,
     TrainingName:null,
     StartDate:null,
     EndDate:null
   }
  }
 

  onSubmit(form: NgForm){
    
this.insertRecord(form);
  }


  insertRecord(form:NgForm){
this.service.postTraining(form.value).subscribe(res=>{ 
this.showMsg = true;
//  this.resetForm(form);
})
  };
}
