<template>
  <div class="login-component">
      <form class="form-signin">   
        <div class="row">
          <div class="col-md-2"></div>
          <div class="col-md-8" id="heading_title">
            <h3 class="form-signin-heading" name="heading title">MVProduction</h3>
          </div>
          <div class="col-md-2"></div>
        </div>
        <div class="row">
          <div class="col-md-1"></div>
          <div class="col-md-5">
            <label for="account_name_input" id="account_name_label" name="account_name_label">Account Name</label>
          </div>
          <div class="col-md-5">
            <input class="form-control nput" v-model="loginModel.AccountName" type="text" id="account_name_input" name="account_name_input" />
          </div>
          <div class="col-md-1"></div>
        </div>
        <div class="row">
          <div class="col-md-1"></div>
          <div class="col-md-5">
            <label for="password_input" id="password_label" name="password_label">Password</label>
          </div>
          <div class="col-md-5">
            <input class="form-control nput" v-model="loginModel.Password" type="password" id="password_input" name="password_input" />
          </div>
          <div class="col-md-1"></div>
        </div>
        <div class="row">
          <div class="col-md-2"></div>
          <div class="col-md-4">
            <button class="btn btn-lg btn-primary btn-block" type="submit" id="login_button" name="login_button" v-on:click="OnLoginClicked">Login</button>
          </div>
          <div class="col-md-3">
            <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="create_account_button" name="create_account_button">Create Account</router-link>
          </div>
          <div class="col-md-3"></div>
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
      var isValid = this.loginService.validateLogin(this.loginModel.AccountName, this.loginModel.Password);

      if (isValid) {
        this.$router.push('/MainMenu');
        
      }
      else {
        console.log("PRRST");
      }
      
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
    background: url("http://www.hdwallpaperspulse.com/wp-content/uploads/2017/04/11/navy-blue-wallpaper-for-desktop.jpg") no-repeat 50% 50%;
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
    height: 25px;
    padding: 0;
    margin: 0;
  }

  /*Header Title*/

  .form-signin-heading {
    height: 2.3em;
    display: flex;
    text-align: center;
    color: white;
    font-family: 'Urban Brush Zone';
    font-size: 100px;
    margin: 0 auto;
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
    padding-right: 3em;
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
    padding-bottom: 0.5em;
    display: flex;
  }

  #account_name_label {
    margin: 0;
    padding: 0;
    display: block;
    font-size: 24px;
    color: white;
    text-align:right;
  }

  #account_name_input {
    margin: 0;
    padding-left: 2em;
    display: block;
    font-size: 100%;
  }

   #password_label {
    margin: 0;
    padding: 0;
    display: block;
    font-size: 24px;
    padding-top: .33em;
    text-align:right;
    color: white;
  }

 #password_input {
    margin: 0;
    padding-left: 2em;
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
    margin-top: 1em;
    margin-left: 4em;
    border: 2px solid rgba(255,255,255,1);
    -webkit-border-radius: 30px;
    border-radius: 30px;
    font: normal 20px "Advent Pro", Helvetica, sans-serif;
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
    width: 150px;
    height: 30px;
    cursor: pointer;
    margin: 0 auto;
    margin-top: 1em;
    margin-left: 3em;
    border: 2px solid rgba(255,255,255,1);
    -webkit-border-radius: 40px;
    border-radius: 40px;
    font: normal 20px "Advent Pro", Helvetica, sans-serif;
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

  #close-btn, #max-btn, #min-btn {
    float: right;
    /*margin-right: 1em;*/
    appearance: none;
    -webkit-appearance: none;
    -moz-appearance: none;
    outline: none;
    border: 0;
    background: transparent;
    color: white;
  }

  #heading_title {
    text-align: center;
  }
</style>
