<template>
  <div class="login-component">
      <form class="form-signin">
        <div class="row">
          <div class="col-md-4"></div>
          <div class="col-md-4">
            <h1 class="form-signin-heading" id="heading_title" name="heading title">MVProduction</h1>
            <div class="row">
              <label for="account_name_input" class="col-xs-12 col-md-6" id="account_name_label" name="account_name_label">Account Name</label>
              <div class="col-xs-6 col-md-6">
                <input class="form-control nput" v-model="loginModel.AccountName" type="text" id="account_name_input" name="account_name_input" /> 
              </div>
            </div>
            <div class="row">
              <label for="password_input" class="col-xs-12 col-md-6" id="password_label" name="password_label">Password</label>
              <div class="col-xs-6 col-md-6">
                <input class="form-control nput" v-model="loginModel.Password" type="password" id="password_input" name="password_input" />
              </div>
            </div>
            <div class="row">
              <div class="col-xs-6 col-md-6">
                <button class="btn btn-lg btn-primary btn-block" type="submit" id="login_button" name="login_button" v-on:click="OnLoginClicked">Login</button>
              </div>
              <div class="col-xs-6 col-md-6">
                <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="create_account_button" name="create_account_button">Create Account</router-link>
              </div>
            </div>
          </div>
        </div>
      </form>
    </div>
</template>

<script lang="ts">
  import Vue from 'vue'
  import Component from 'vue-class-component'
  import { iocContainer } from '../inversify.config'
  import { ILoginService } from '../services/login.service'
  import { TYPES } from '../RegitredTypes'

  interface ILoginComponent {
    loginModel: LoginModel
    OnLoginClicked(): void
    OnCreateAccountClicked(): void
  }

  class LoginModel {
    AccountName: string;
    Password: string;
  }

  @Component
  export default class LoginComponent extends Vue implements ILoginComponent {
    loginModel: LoginModel = new LoginModel();
    loginService: ILoginService = iocContainer.get<ILoginService>(TYPES.ILoginService);

    OnLoginClicked(): void {
      alert("Account Name: " + this.loginModel.AccountName + "\nPassword: " + this.loginModel.Password);
      this.loginService.validateLogin(this.loginModel.AccountName, this.loginModel.Password);
    }

    OnCreateAccountClicked(): void {
      alert("Create account");
    }

  } 
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style >

  /* Html and Body */
  html, body {
    margin: 0;
    padding: 0;
    height: 100%;
    width: 100%;
    overflow: hidden;
  }

  /* Container */
  .container-fluid {
    height: 100%;
    width: 100%;
    position: absolute;
    margin: auto;
    background: url("https://phoenixrp.co.uk/uploads/monthly_2016_10/logo-88-msi-dragon-burning.jpg.ca99700717b3e62bd5f59c3581ffa3fc.jpg") no-repeat 50% 50%;
    display: table;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-size: cover;
  }

  /*Title Bar*/
  #title-bar {
    -webkit-app-region: drag;
    height: 24px;
    width: 100%;
    padding: 0;
    margin: 0;
  }

  /*Header Title*/

  .form-signin-heading {
    height: 3.6em;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-family: 'Urban Brush Zone';
    font-size: 100px;
    padding-left: .5em;
  }

  #account_name_input {
    display: inline-block;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
    width: 150px;
    height: 42px;
    cursor: pointer;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    padding: 0 20px;
    overflow: hidden;
    border: 3px solid white;
    -webkit-border-radius: 21px;
    border-radius: 21px;
    font: normal 20px/normal "Antic", Helvetica, sans-serif;
    color: rgba(140,140,140,1);
    text-decoration: normal;
    -o-text-overflow: ellipsis;
    text-overflow: ellipsis;
    background: rgba(40,40,40,0.4);
    -webkit-box-shadow: 1px 1px 2px 0 rgba(0,0,0,0.5) inset;
    box-shadow: 1px 1px 2px 0 rgba(0,0,0,0.5) inset;
    -webkit-transition: all 502ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -moz-transition: all 502ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -o-transition: all 502ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    transition: all 502ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
  }

  #account_name_input:hover {
    color: rgba(181,181,181,1);
    background: rgba(0,0,0,0.4);
    -webkit-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -moz-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -o-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
  }

  #account_name_input:focus {
    width: 213px;
    cursor: default;
    padding: -13px 20px 0;
    color: rgba(255,255,255,1);
    -webkit-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -moz-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -o-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
  }

  #password_input {
    display: inline-block;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
    width: 150px;
    height: 42px;
    cursor: pointer;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    padding: 0 20px;
    overflow: hidden;
    border: 3px solid white;
    -webkit-border-radius: 21px;
    border-radius: 21px;
    font: normal 20px/normal "Antic", Helvetica, sans-serif;
    color: rgba(140,140,140,1);
    text-decoration: normal;
    -o-text-overflow: ellipsis;
    text-overflow: ellipsis;
    background: rgba(40,40,40,0.4);
    -webkit-box-shadow: 1px 1px 2px 0 rgba(0,0,0,0.5) inset;
    box-shadow: 1px 1px 2px 0 rgba(0,0,0,0.5) inset;
    -webkit-transition: all 502ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -moz-transition: all 502ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -o-transition: all 502ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    transition: all 502ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
  }

  #password_input:hover {
    color: rgba(181,181,181,1);
    background: rgba(0,0,0,0.4);
    -webkit-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -moz-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -o-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
  }

  #password_input:focus {
    width: 213px;
    cursor: default;
    padding: -13px 20px 0;
    color: rgba(255,255,255,1);
    -webkit-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -moz-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -o-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
  }

  .row {
    margin: 0;
    padding: 0;
    padding-bottom: 1.25em;
    padding-right: 4em;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .row #account_name_label {
    margin: 0;
    padding: 0;
    display: block;
    font-size: 24px;
    padding-top: .33em;
    padding-right: 1em;
    width: 10em;
    text-align: right;
    float: left;
    color: white;
  }

  .row #account_name_input {
    margin: 0;
    padding-left: -50px;
    display: block;
    font-size: 100%;
  }

  .row #password_label {
    margin: 0;
    padding: 0;
    display: block;
    font-size: 24px;
    padding-top: .33em;
    padding-right: 1em;
    width: 10em;
    text-align: right;
    float: left;
    color: white;
    align-items: center;
    justify-content: center;
  }

  .row #password_input {
    margin: 0;
    padding-left: -50px;
    display: block;
    font-size: 100%;
  }

  #login_button {
    -webkit-box-sizing: content-box;
    -moz-box-sizing: content-box;
    box-sizing: content-box;
    width: 150px;
    height: 30px;
    cursor: pointer;
    margin: 0 auto;
    margin-left: 5em;
    margin-top: 1em;
    border: 2px solid rgba(255,255,255,1);
    -webkit-border-radius: 40px;
    border-radius: 40px;
    font: normal 24px "Advent Pro", Helvetica, sans-serif;
    color: rgba(255,255,255,1);
    text-align: center;
    -o-text-overflow: clip;
    text-overflow: clip;
    letter-spacing: 1px;
    background: rgba(0,0,0,0);
    -webkit-transition: background-color 0.3s cubic-bezier(0, 0, 0, 0), color 0.3s cubic-bezier(0, 0, 0, 0), width 0.3s cubic-bezier(0, 0, 0, 0), border-width 0.3s cubic-bezier(0, 0, 0, 0), border-color 0.3s cubic-bezier(0, 0, 0, 0);
    -moz-transition: background-color 0.3s cubic-bezier(0, 0, 0, 0), color 0.3s cubic-bezier(0, 0, 0, 0), width 0.3s cubic-bezier(0, 0, 0, 0), border-width 0.3s cubic-bezier(0, 0, 0, 0), border-color 0.3s cubic-bezier(0, 0, 0, 0);
    -o-transition: background-color 0.3s cubic-bezier(0, 0, 0, 0), color 0.3s cubic-bezier(0, 0, 0, 0), width 0.3s cubic-bezier(0, 0, 0, 0), border-width 0.3s cubic-bezier(0, 0, 0, 0), border-color 0.3s cubic-bezier(0, 0, 0, 0);
    transition: background-color 0.3s cubic-bezier(0, 0, 0, 0), color 0.3s cubic-bezier(0, 0, 0, 0), width 0.3s cubic-bezier(0, 0, 0, 0), border-width 0.3s cubic-bezier(0, 0, 0, 0), border-color 0.3s cubic-bezier(0, 0, 0, 0);
    }

  #login_button:hover {
    background: rgba(255,255,255,1);
  }

  #login_button:active {
    -webkit-transition: none;
    -moz-transition: none;
    -o-transition: none;
    transition: none;
  }

  #create_account_button {
    -webkit-box-sizing: content-box;
    -moz-box-sizing: content-box;
    box-sizing: content-box;
    width: 200px;
    height: 30px;
    cursor: pointer;
    margin: 0 auto;
    margin-top: 1em;
    margin-left: 2.5em;
    border: 2px solid rgba(255,255,255,1);
    -webkit-border-radius: 40px;
    border-radius: 40px;
    font: normal 24px "Advent Pro", Helvetica, sans-serif;
    color: rgba(255,255,255,1);
    text-align: center;
    -o-text-overflow: clip;
    text-overflow: clip;
    letter-spacing: 1px;
    background: rgba(0,0,0,0);
    -webkit-transition: background-color 0.3s cubic-bezier(0, 0, 0, 0), color 0.3s cubic-bezier(0, 0, 0, 0), width 0.3s cubic-bezier(0, 0, 0, 0), border-width 0.3s cubic-bezier(0, 0, 0, 0), border-color 0.3s cubic-bezier(0, 0, 0, 0);
    -moz-transition: background-color 0.3s cubic-bezier(0, 0, 0, 0), color 0.3s cubic-bezier(0, 0, 0, 0), width 0.3s cubic-bezier(0, 0, 0, 0), border-width 0.3s cubic-bezier(0, 0, 0, 0), border-color 0.3s cubic-bezier(0, 0, 0, 0);
    -o-transition: background-color 0.3s cubic-bezier(0, 0, 0, 0), color 0.3s cubic-bezier(0, 0, 0, 0), width 0.3s cubic-bezier(0, 0, 0, 0), border-width 0.3s cubic-bezier(0, 0, 0, 0), border-color 0.3s cubic-bezier(0, 0, 0, 0);
    transition: background-color 0.3s cubic-bezier(0, 0, 0, 0), color 0.3s cubic-bezier(0, 0, 0, 0), width 0.3s cubic-bezier(0, 0, 0, 0), border-width 0.3s cubic-bezier(0, 0, 0, 0), border-color 0.3s cubic-bezier(0, 0, 0, 0);
  }

  #create_account_button:hover {
    background: rgba(255,255,255,1);
  }

  #create_account_button:active {
    -webkit-transition: none;
    -moz-transition: none;
    -o-transition: none;
    transition: none;
  }

  #close-btn, max-btn, min-btn {
   
  }


  
  /*@media screen and (max-width: 768px) {
    .content h1 {
      font-size: 250%;
    }

    .btn {
      font-size: 110%;
      padding: 7px 15px;
    }
  }*/

</style>
