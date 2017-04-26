import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { LoginService } from '../Services/login.service';

export class LoginModel {
    AccountName: string;
    Password: string;
}

@Component({
    selector: 'app-login',
    templateUrl: './app/Login/app_component_login.html',
    styleUrls: ['./app/Login/app_component_login.css'],
    viewProviders: [LoginService]
})

export class LoginComponent {
    LoginModel: LoginModel = new LoginModel();
    LoginService: LoginService;
    constructor(loginService : LoginService) {
        this.LoginService = loginService;
    }

    LoginButtonClicked(event) {
        alert("Account Name: " + this.LoginModel.AccountName + "\nPassword: " + this.LoginModel.Password);

        this.LoginService.ValidateLogin(this.LoginModel.AccountName, this.LoginModel.Password);

    }
}