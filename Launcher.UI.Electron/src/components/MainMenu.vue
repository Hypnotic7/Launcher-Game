<template>
  <div class="main-menu-component">
    <div class="col-md-6" id="heading_title">
      <h1 class="form-signin-heading" name="heading title">MVProduction</h1>
    </div>
    <div class="row">
       
    </div>

    <div class="row">

    </div>

    <div class="row">
      <div class="col-md-2"></div>
      <div class="col-md-4">
        <button type="button" id="logout_button" name="logout_button" class="btn btn-primary btn-lg" v-on:click="OnLogoutClicked">
            <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
          </router-link>
        </button>
      </div>
    </div>

  </div>
</template>

<script lang="ts">
  import Vue from 'vue'
  import Component from 'vue-class-component'
  import { iocContainer } from '../inversify.config'
  import { IMainMenuService } from '../services/main.menu.service'
  import { TYPES } from '../RegitredTypes'

  interface IMainMenuComponent {
    OnLogoutClicked(): void

  }

   class MainMenuModel {
    AccountName: string;
  }

  @Component
  export default class MainMenuComponent extends Vue implements IMainMenuComponent {

    mainMenuModel: MainMenuModel = new MainMenuModel();
    mainMenuService: IMainMenuService = iocContainer.get<IMainMenuService>(TYPES.IMainMenuService);

    OnLogoutClicked(): void {
      this.mainMenuModel.AccountName = "Test";
      alert("Logging out");
      var loggedOut = this.mainMenuService.logout(this.mainMenuModel.AccountName);

      if (loggedOut) {
        this.$router.push('/Login');
      } else {
        console.log("Could not log out")
      }
    }

  }


</script>

<style>

  /* Html and Body */
  .main-menu-component {
    margin: 0;
    padding: 0;
    height: 100%;
    width: 100%;
    overflow: hidden;
  }

  /* Container */
  .main-menu-component {
    height: 100%;
    width: 100%;
    position: absolute;
    margin: auto;
    display: table;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-size: cover;
    background: url("http://vignette2.wikia.nocookie.net/the-next-tdrp/images/b/b9/Camp_Wawanakwa_TDI.jpg/revision/latest?cb=20160223061728") no-repeat 50% 50%;
  }

</style>