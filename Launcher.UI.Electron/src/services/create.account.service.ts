import { injectable, inject } from 'inversify';
import "reflect-metadata";
const config = require('../../endpointconfig.json');

export interface ICreateAccount {
    createAccount(email: string, accountName: string, accountPassword: string, accountRetypePassword: string): boolean;
}

@injectable()
export class CreateAccountService implements ICreateAccount {

  private url: string = config.ApiEndpoints.CreateAccountEndpoint; 

    createAccount(email: string, accountName: string, accountPassword: string, accountRetypePassword: string): boolean {
        alert("Creating account");
        if (accountPassword !== accountRetypePassword) {
          console.log("Passwords Doesn't match");
          return false;
        }
        if (email.split('@').length > 1) {
          if (email.split('.').length > 1) {
            var xHttpRequest: XMLHttpRequest = new XMLHttpRequest();
            xHttpRequest.open("POST", this.url, false);
            xHttpRequest.setRequestHeader("Content-type", "application/json");
            xHttpRequest.send(JSON.stringify({
              Email: email,
              AccountName: accountName,
              AccountPassword: accountPassword,
              AccountRetypePassword: accountRetypePassword
            }));
            var response = xHttpRequest.responseText;
            console.log(response);
            return true;
          }
        } else {
          console.log("Invalid Email Address");
          return false;
        }
      return false;

    }
}

