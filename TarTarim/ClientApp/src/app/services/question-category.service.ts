import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ToastrService} from "ngx-toastr";
import {TokenService} from "./token.service";
import {ListResponseModel} from "../models/responseModels";
import {ClaimModel} from "../models/claimModel";
import {ApiUrlHelper} from "../helpers/apiHelper";
import {QuestionCategoryModel} from "../models/questionCategory";

@Injectable({
  providedIn: 'root'
})
export class QuestionCategoryService {

  constructor(private httpClient: HttpClient) { }

  getQuestionCategories(){
    return this.httpClient.get<ListResponseModel<QuestionCategoryModel>>(ApiUrlHelper.getUrl("QuestionCategory"))
  }
}
