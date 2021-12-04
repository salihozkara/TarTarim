import { AuthService } from 'src/app/services/auth.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {AnswerService} from "../../services/answer.service";

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit {

  constructor(private activatedRoute: ActivatedRoute,private authService:AuthService,private answerService:AnswerService) { }
  isAuthenticated:boolean
  ngOnInit(): void {
    this.isAuthenticated=this.authService.isAuthenticated();
    this.activatedRoute.params.subscribe(p=>console.log(p))
  }
  yorumYap(yorum){

    this.answerService.getAnswerByQuestionId(2).subscribe(r=>console.log("aaaa",r))

    yorum.value=""
  }
}
