import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { Router } from '@angular/router';
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

    constructor(private router : Router, private loginService: LoginService) {
    }

    LoginButtonClicked(event) {
        alert("Account Name: " + this.LoginModel.AccountName + "\nPassword: " + this.LoginModel.Password);

        this.loginService.ValidateLogin(this.LoginModel.AccountName, this.LoginModel.Password);

    }

    CreateAccountClicked(event) {
        this.router.navigate(['/CreateAccount']);
    }
}