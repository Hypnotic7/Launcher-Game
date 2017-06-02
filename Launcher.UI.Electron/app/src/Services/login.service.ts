import { injectable, inject } from "inversify";
import "reflect-metadata";

export interface ILoginService {
    ValidateLogin(AccountName: string, AccountPassword: string) : boolean
}

@injectable()
export class LoginService {

    readonly url: string = "http://localhost:8080/api/Login";

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

let TYPES = {
    ILoginService: "ILoginService"
};

export { TYPES };
