<template>
  <div class="create-account-component">

    <div class="row">
      <div class="col-md-3"></div>
      <div class="col-md-7" id="heading_title">
        <h3 class="form-signin-heading" name="heading title" color="black">Create Account</h3>
      </div>
      <div class="col-md-2"></div>
    </div>

    <div class="row">
      <div class="col-md-1"></div>
      <div class="col-md-5">
        <label for="email_input" id="email_label" name="email_label">Email</label>
      </div>
      <div class="col-md-5">
        <input class="form-control nput" v-model="createAccountModel.Email" type="text" id="email_input" name="email_input" />
      </div>
      <div class="col-md-1"></div>
    </div>

    <div class="row">
      <div class="col-md-1">
        <router-link :to="{name:'Login'}" tag="button" class="btn btn-primary btn-lg" id="return_to_login_page" name="return_to_login_page">
          <span class="glyphicon glyphicon-menu-left" aria-hidden="true"></span>
        </router-link>          
      </div>
      <div class="col-md-5">
        <label for="account_name_input" id="account_name_label" name="account_name_label">Account Name</label>
      </div>
      <div class="col-md-5">
        <input class="form-control nput" v-model="createAccountModel.AccountName" type="text" id="account_name_input" name="account_name_input" />
      </div>
      <div class="col-md-1"></div>
    </div>

    <div class="row">
      <div class="col-md-1"></div>
      <div class="col-md-5">
        <label for="password_input" id="password_label" name="password_label">Password</label>
      </div>
      <div class="col-md-5">
        <input class="form-control nput" v-model="createAccountModel.Password" type="password" id="password_input" name="password_input" />
      </div>
      <div class="col-md-1"></div>
    </div>

    <div class="row">
      <div class="col-md-1"></div>
      <div class="col-md-5">
        <label for="retype_password_input" id="password_label" name="retype_password_label">Retype Password</label>
      </div>
      <div class="col-md-5">
        <input class="form-control nput" v-model="createAccountModel.RetypePassword" type="password" id="retype_password_input" name="retype_password_input" />
      </div>
      <div class="col-md-1"></div>
    </div>

    <div class="row">
      <div class="col-md-4"></div>
      <div class="col-md-4">
        <button class="btn btn-lg btn-primary btn-block" type="submit" id="create_account_button" name="create_account_button" v-on:click="OnCreateAccountClicked">Create Account</button>
      </div>
      <div class="col-md-4"></div>
    </div> 

  </div>

</template>

<script lang="ts">

  import Vue from 'vue'
  import Component from 'vue-class-component'
  import { CreateAccountService } from '../services/create.account.service';
  import { iocContainer } from '../inversify.config'

  interface ICreateAccountComponent {
    OnCreateAccountClicked(): void;
  }

  export class CreateAccountModel {
        Email: string;
        AccountName: string;
        Password: string;
        RetypePassword: string;        
    }

  @Component
  export default class CreateAccountComponent extends Vue implements ICreateAccountComponent
    {
        createAccountModel: CreateAccountModel = new CreateAccountModel();
        createAccountService: CreateAccountService = new CreateAccountService();

        OnCreateAccountClicked(): void {
          alert("Email: " + this.createAccountModel.Email + "\nAccount Name: " + this.createAccountModel.AccountName + "\nPassword: " + this.createAccountModel.Password + "\nRetypePassword" + this.createAccountModel.RetypePassword);
          this.createAccountService.createAccount(this.createAccountModel.Email, this.createAccountModel.AccountName,
                                                  this.createAccountModel.Password, this.createAccountModel.RetypePassword);

        }
    }
</script>

<style>

  #email_label {
    margin: 0;
    padding: 0;
    display: block;
    font-size: 24px;
    padding-top: .33em;
    color: black;
    text-align: right;
    border: 10px;
  }

  #email_input, #retype_password_input {
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

  #email_input:hover, #retype_password_input:hover {
    color: rgba(181,181,181,1);
    background: rgba(0,0,0,0.4);
    -webkit-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -moz-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -o-transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    transition: all 500ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
  }

  #email_input:focus, #retype_password_input:focus {
    width: 213px;
    cursor: default;
    padding: -13px 20px 0;
    color: rgba(255,255,255,1);
    -webkit-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -moz-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    -o-transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
    transition: all 601ms cubic-bezier(0.68, -0.75, 0.265, 1.75);
  }

  #email_input, #retype_password_input {
    margin: 0;
    padding-left: 2em;
    display: block;
    font-size: 100%;
  }

  #return_to_login_page {
    appearance: none;
    -webkit-appearance: none;
    -moz-appearance: none;
    outline: none;
    border: 0;
    background: transparent;
    color: black;
  }

</style>