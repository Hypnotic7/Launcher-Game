import Vue from 'vue'
import Component from 'vue-class-component'
import { iocContainer } from '../inversify.config'
import { ILoginService, TYPES } from '../Services/login.service'


export class LoginModel {
    AccountName: string;
    Password: string;
}


interface ILoginComponent {
    loginModel: LoginModel
    OnLoginClicked(): void
    OnCreateAccountClicked(): void
}

@Component({
    template: '',
    el:'#login-component'
})
export default class LoginComponent extends Vue implements ILoginComponent {
    loginModel: LoginModel = new LoginModel();
    loginService: ILoginService = iocContainer.get<ILoginService>(TYPES.ILoginService);
      
    OnLoginClicked(): void
    {
        alert("Account Name: " + this.loginModel.AccountName + "\nPassword: " + this.loginModel.Password);
        this.loginService.ValidateLogin(this.loginModel.AccountName, this.loginModel.Password);
    }

    OnCreateAccountClicked(): void
    {
        alert("Create account");
    }
    
} 