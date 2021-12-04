import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ListResponseModel} from "../models/responseModels";
import {ApiUrlHelper} from "../helpers/apiHelper";
import {QuestionSubCategoryModel} from "../models/questionSubCategoryModel";

@Injectable({
  providedIn: 'root'
})
export class QuestionSubCategoryService {

  constructor(private httpClient: HttpClient) { }

  getQuestionCategoryById(id:number){
    let paramaters = new Map<string, string | number | boolean>();
    paramaters.set("id",id);
    return this.httpClient.get<ListResponseModel<QuestionSubCategoryModel>>(ApiUrlHelper.getUrlWithParameters("QuestionSubCategory/getQuestionCategoryById",paramaters))

  }
}
