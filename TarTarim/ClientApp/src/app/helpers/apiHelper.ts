import { Inject } from "@angular/core";
import {getBaseUrl} from "../../main";

export class ApiUrlHelper {
    static apiUrl:string=getBaseUrl();
    static apiPrefix:string="api/"
    static getUrl(path: string): string {
      return this.apiUrl + this.apiPrefix + path;
    }

    static getUrlWithParameters(path: string, parameters: Map<string,string|number|boolean>): string {
      let baseUrl = this.getUrl(path) + '?';
      parameters.forEach((v,k)=>{
          baseUrl+=`${k}=${v}&`
      })
      return baseUrl;
    }
  }
