import { Component, OnInit } from '@angular/core';
import {QuestionCategoryModel} from "../../models/questionCategory";
import {QuestionCategoryService} from "../../services/question-category.service";
import {QuestionSubCategoryService} from "../../services/question-sub-category.service";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private questionCategoryService:QuestionCategoryService,private questionSubCategoryService:QuestionSubCategoryService) { }
  questionCategories:QuestionCategoryModel[]
  questionSubCategories=[]
  getSubcategory(id: number) {
    let result=this.questionSubCategoryService.getQuestionCategoryById(id).subscribe(r=>this.questionSubCategories[id]=r.data)
  }
  ngOnInit(): void {
    this.questionCategoryService.getQuestionCategories().subscribe(r=>{this.questionCategories=r.data
    r.data.forEach(d=>this.getSubcategory(d.id))})

  }

}
