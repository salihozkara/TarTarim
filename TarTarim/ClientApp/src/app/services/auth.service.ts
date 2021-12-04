import { Token } from './../models/tokenModels';
import { SingleResponseModel } from './../models/responseModels';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiUrlHelper } from '../helpers/apiHelper';
import { ToastrService } from 'ngx-toastr';
import { TokenService } from './token.service';
import { Router } from '@angular/router';
import { timer } from 'rxjs';
import jwt_decode from "jwt-decode";
import { User } from '../models/userModel';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  getLoginPath: string = 'auth/Login';
  getRegisterPath: string = 'auth/Register';
  constructor(private httpClient: HttpClient,private toastrService: ToastrService,
    private tokenService: TokenService) { }
  isAuthenticated(){
    return this.tokenService.tokenExist();
  }
  login(loginModel){
    return this.httpClient.post<SingleResponseModel<Token>>(
      ApiUrlHelper.getUrl(this.getLoginPath),
      loginModel
    );
  }
  register(registerModel){
    return this.httpClient.post<SingleResponseModel<Token>>(
      ApiUrlHelper.getUrl(this.getRegisterPath),
      registerModel
    );
  }
  isUserHaveClaims(necessaryClaims: string[]): boolean {//verilen role/rollere sahip mi
    if (necessaryClaims == undefined) return false;
    if(this.isAuthenticated()==false){
      return false;
    }
    let isUserHaveClaim: boolean = false;

    let claims:string=JSON.parse(JSON.stringify(jwt_decode(this.tokenService.getToken()))).roles//jwt üzerinden decode ile çekiyor
    claims.toString().split(",").forEach((ownedClaim) => {//string olarak gelen rolleri virgül ile ayırıp rol karşılaştırıyor
      necessaryClaims.forEach((necessaryClaim) => {
        if (ownedClaim === 'admin' || ownedClaim === necessaryClaim) {
          isUserHaveClaim = true;
        }
      });
    });
    return isUserHaveClaim;
  }
  getUser(): User {//jwt içerisinden user verilerini decode etme
    let token:string=this.tokenService.getToken()
    let user: User = jwt_decode(token)
    return user;
  }

  logout() {
    this.tokenService.delete();//tokeni sil
    this.toastrService.success('Başarıyla çıkış yaptınız.');
    timer(100).subscribe(p=>{
      window.location.reload();
    });
  }
}


