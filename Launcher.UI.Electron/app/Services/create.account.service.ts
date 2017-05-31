import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';

@Injectable()
export class CreateAccountService {

    readonly url: string = "http://localhost:8080/api/CreateAccount"; 


    CreateAccount(AccountName: string, AccountPassword: string, Email: string): boolean {
        alert("Creating account");

        return true;
    }
}
