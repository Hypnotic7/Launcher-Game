import { Component } from '@angular/core';

export class LoginModel {
    AccountName: string;
    Password: string;
}

@Component({
    selector: 'app-login',
    templateUrl: './app/Login/app_component_login.html',
    styleUrls: ['./app/Login/app_component_login.css']
})

export class LoginComponent {
    LoginModel: LoginModel = new LoginModel();

    LoginButtonClicked(event) {
        alert("Account Name: " + this.LoginModel.AccountName + "\nPassword: " + this.LoginModel.Password);
    }
}