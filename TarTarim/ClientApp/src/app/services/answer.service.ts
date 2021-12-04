import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ToastrService} from "ngx-toastr";
import {TokenService} from "./token.service";
import {ListResponseModel} from "../models/responseModels";
import {ClaimModel} from "../models/claimModel";
import {ApiUrlHelper} from "../helpers/apiHelper";
import {AnswerModel} from "../models/answerModel";

@Injectable({
  providedIn: 'root'
})
export class AnswerService {

  constructor(private httpClient: HttpClient,private toastrService: ToastrService,
              private tokenService: TokenService) { }
  getAnswerByQuestionId(id:number){
    let paramaters = new Map<string, string | number | boolean>();
    paramaters.set("id",id);
    return this.httpClient.get<ListResponseModel<AnswerModel>>(ApiUrlHelper.getUrlWithParameters("Answer/getAnswerByQuestionId",paramaters))
  }
  getAnswersForQuestions(id:number){
    let paramaters = new Map<string, string | number | boolean>();
    paramaters.set("id",id);
    return this.httpClient.get<number>(ApiUrlHelper.getUrlWithParameters("Answer/getAnswersForQuestions",paramaters))

  }
}
