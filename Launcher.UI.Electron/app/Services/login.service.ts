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
        alert("start validating login");
        var xHttpRequest: XMLHttpRequest = new XMLHttpRequest();
        xHttpRequest.open("POST", this.url, false);
        xHttpRequest.setRequestHeader("Content-type", "application/json");
        xHttpRequest.send(JSON.stringify({ accountName : AccountName,accountPassword : AccountPassword}));

        var response = xHttpRequest.responseText;
        
        console.log(response);
        return true;
    }
    
}
