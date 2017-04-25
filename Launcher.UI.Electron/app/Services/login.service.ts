import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';

@Injectable()
export class LoginService {

    readonly url: string = "http://localhost:49455/api/Login";
    readonly http: Http;

    constructor(http: Http) {
        this.http = http;
    }

    ValidateLogin(AccountName : string, AccountPassword : string): boolean {

        var response = this.http.get(this.url);
        

        return true;
    }
    
}
