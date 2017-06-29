import { injectable, inject } from 'inversify';
import "reflect-metadata";

export interface ICreateAccount {
    createAccount(email: string, accountName: string, accountPassword: string, accountRetypePassword: string): boolean;
}

@injectable()
export class CreateAccountService implements ICreateAccount {

    readonly url: string = "http://localhost:8080/api/CreateAccount"; 


    createAccount(email: string, accountName: string, accountPassword: string, accountRetypePassword: string): boolean {
        alert("Creating account");

        var xHttpRequest: XMLHttpRequest = new XMLHttpRequest();
        xHttpRequest.open("POST", this.url, false);
        xHttpRequest.setRequestHeader("Content-type", "application/json");
        xHttpRequest.send(JSON.stringify({ Email: email, AccountName: accountName, AccountPassword: accountPassword, AccountRetypePassword: accountRetypePassword }));
        var response = xHttpRequest.responseText;
        console.log(response);
        return true;
    }
}

