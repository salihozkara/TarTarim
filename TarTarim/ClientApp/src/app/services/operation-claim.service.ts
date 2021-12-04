import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ToastrService} from "ngx-toastr";
import {ListResponseModel} from "../models/responseModels";
import {ApiUrlHelper} from "../helpers/apiHelper";
import { ClaimModel } from '../models/claimModel';

@Injectable({
  providedIn: 'root'
})
export class OperationClaimService {
  getClaimsPath: string = 'operationclaim/getoprationclaims';
  constructor(private httpClient: HttpClient,private toastrService: ToastrService) { }

  getClaims(){
    return this.httpClient.get<ListResponseModel<ClaimModel>>(ApiUrlHelper.getUrl(this.getClaimsPath))
  }
}
