import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { CreateAccountService } from '../Services/create.account.service';

export class CreateAccountModel {
    AccountName: string;
    Password: string;
    Email: string;
}

@Component({
    selector: 'app-create-account',
    templateUrl: './app/CreateAccount/app.component.create.account.html',
    styleUrls: ['./app/CreateAccount/app.component.create.account.css'],
    viewProviders: [CreateAccountService]
})

export class CreateAccountComponent
{
    CreateAccountModel: CreateAccountModel = new CreateAccountModel();
    CreateAccountService: CreateAccountService = new CreateAccountService();

    constructor() {
        
    }

}