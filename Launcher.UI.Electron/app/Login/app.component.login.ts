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
    providers: [LoginService]
})

export class LoginComponent {
    LoginModel: LoginModel = new LoginModel();
    LoginService: LoginService = new LoginService(new Http(null,null));

    LoginButtonClicked(event) {
        alert("Account Name: " + this.LoginModel.AccountName + "\nPassword: " + this.LoginModel.Password);

        this.LoginService.ValidateLogin(this.LoginModel.AccountName, this.LoginModel.Password);

    }
}