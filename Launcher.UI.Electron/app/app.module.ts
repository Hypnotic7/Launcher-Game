import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { LoginService } from "./Services/login.service";
import { CreateAccountService } from "./Services/create.account.service";

import { LoginComponent } from './login/app.component.login';
import { CreateAccountComponent } from "./createaccount/app.component.create.account";



@NgModule({
  declarations: [
      LoginComponent,
      CreateAccountComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot([{ path: '', redirectTo: '/Login', pathMatch: 'full' },
                          { path: 'Login', component: LoginComponent },
                          { path: 'CreateAccount',component: CreateAccountComponent}
    ])
  ],
  providers: [LoginService, CreateAccountService],
  bootstrap: [LoginComponent]
})
export class AppModule { }
