import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ToastrService} from "ngx-toastr";
import {TokenService} from "./token.service";
import {ListResponseModel, SingleResponseModel} from "../models/responseModels";
import {AnswerModel} from "../models/answerModel";
import {ApiUrlHelper} from "../helpers/apiHelper";
import {ReplyAnswerModel} from "../models/replyAnswerModel";

@Injectable({
  providedIn: 'root'
})
export class ReplyAnswerService {
  constructor(private httpClient: HttpClient,private toastrService: ToastrService,
              private tokenService: TokenService) { }
  getReplyAnswerByReplyId(id:number){
    let paramaters = new Map<string, string | number | boolean>();
    paramaters.set("id",id);
    return this.httpClient.get<ListResponseModel<ReplyAnswerModel>>(ApiUrlHelper.getUrlWithParameters("replyAnswer/getReplyAnswerByReplyId",paramaters))
  }
}
