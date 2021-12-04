import { AnswerModel } from './../../models/answerModel';
import { AuthService } from 'src/app/services/auth.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {AnswerService} from "../../services/answer.service";
import { QuestionModel } from 'src/app/models/questionModel';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit {

  constructor(private activatedRoute: ActivatedRoute,private authService:AuthService,private answerService:AnswerService) { }
  isAuthenticated:boolean
  questionId:number
  answers:AnswerModel[]
  question:QuestionModel
  ngOnInit(): void {
    this.isAuthenticated=this.authService.isAuthenticated();
    this.activatedRoute.params.subscribe(p=>{
      if(p["question"]){this.questionId=p["id"];this.getAnswers()}
    })
  }
  getAnswers(){
    this.answerService.getAnswerByQuestionId(this.questionId).subscribe(r=>this.answers=r.data)
  }
  replyAnswer(yorum){

    this.answerService.getAnswerByQuestionId(2).subscribe(r=>console.log("aaaa",r))

    yorum.value=""
  }
}
