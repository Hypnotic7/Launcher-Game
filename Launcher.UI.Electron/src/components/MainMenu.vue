<template>
  <div class="main-menu-component">
    <div class="main-menu">

      <div class="info-games">
        <div class="row">
          <div class="col-md-3"></div>
          <div class="col-lg-1">
            <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="info_button" name="info_button">
              <span class=" glyphicon glyphicon-info-sign" aria-hidden="true"></span>
            </router-link>
          </div>
          <div class="col-md-4"></div>
          <div class="col-lg-1">
            <router-link :to="{name:'games'}" tag="button" class="btn btn-lg btn-primary btn-block" id="games_button" name="games_button">
              <span class="glyphicon glyphicon-play-circle" aria-hidden="true"></span>
            </router-link>
          </div>
          <div class="col-md-3"></div>
        </div>
      </div>
      <div class="about-education">
        <div class="row">
          <div class="col-md-2"></div>
          <div class="col-lg-1">
            <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="about_creators_button" name="about_creators_button">
              <span class="glyphicon glyphicon-blackboard" aria-hidden="true"></span>
            </router-link>
          </div>
          <div class="col-md-6"></div>
          <div class="col-lg-1">
            <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="education_button" name="education_button">
              <span class="glyphicon glyphicon-education" aria-hidden="true"></span>
            </router-link>
          </div>
          <div class="col-md-2"></div>
        </div>
      </div>

      <div class="settings-achievments">
        <div class="row">
          <div class="col-md-2"></div>
          <div class="col-lg-1">
            <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="settings_button" name="settings_button">
              <span class="glyphicon glyphicon-cog" aria-hidden="true"></span>
            </router-link>
          </div>
          <div class="col-md-6"></div>
          <div class="col-lg-1">
            <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="achievments_button" name="achievments_button">
              <span class="glyphicon glyphicon-star-empty" aria-hidden="true"></span>
            </router-link>
          </div>
          <div class="col-md-2"></div>
        </div>
      </div>

      <div class="shop-communicator">
        <div class="row">
          <div class="col-md-3"></div>
          <div class="col-lg-1">
            <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="shop_button" name="shop_button">
              <span class="glyphicon glyphicon-shopping-cart" aria-hidden="true"></span>
            </router-link>
          </div>
          <div class="col-md-4"></div>
          <div class="col-lg-1">
            <router-link :to="{name:'createAccount'}" tag="button" class="btn btn-lg btn-primary btn-block" id="communicator_button" name="communicator_button">
              <span class="glyphicon glyphicon-send" aria-hidden="true"></span>
            </router-link>
          </div>
          <div class="col-md-3"></div>
        </div>
      </div>
    </div>
      
    <nav class="navbar navbar-fixed-bottom">
        <div class="navbar-header">
          <div class="row">
            <div class="col-md-4">
              <button type="button" id="logout_button" name="logout_button" class="btn btn-primary btn-lg" v-on:click="OnLogoutClicked">
                <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
              </button>
            </div>
            </div>
          <div class="col-md-6"></div>              
          <div class="col-md-2"></div>          
        </div>        
    </nav>
 </div>
  
</template>

<script lang="ts">
  import Vue from 'vue'
  import Component from 'vue-class-component'
  import { iocContainer } from '../inversify.config'
  import { IMainMenuService } from '../services/main.menu.service'
  import { ILoginService } from '../services/login.service'
  import { TYPES } from '../RegitredTypes'

  interface IMainMenuComponent {
    OnLogoutClicked(): void

  }

   class MainMenuModel {
     AccountName: string;
     Password: string;
  }

  @Component
  export default class MainMenuComponent extends Vue implements IMainMenuComponent {

    loginService: ILoginService = iocContainer.get<ILoginService>(TYPES.ILoginService);

    mainMenuModel: MainMenuModel = new MainMenuModel();
    mainMenuService: IMainMenuService = iocContainer.get<IMainMenuService>(TYPES.IMainMenuService);

    OnLogoutClicked(): void {
      this.mainMenuModel.AccountName = "Test";
      this.mainMenuModel.Password = "test";
      alert("Logging out");
      var loggedOut = this.loginService.validateLogin(this.mainMenuModel.AccountName, this.mainMenuModel.Password);

      if (loggedOut) {
        this.$router.push('/');
      } else {
        console.log("Could not log out")
      }
    }

  }


</script>

<style>

  /* Container */
  .container-fluid {
    background: url("http://www.adultswim.com/misc/samurai-jack-backgrounds/media/SAMURAI_JACK_1920X1080_Skulls.png") no-repeat 50% 50%;
  }

  .main-menu{
    margin-top: 4em;
  }
  .shop-communicator, .settings-achievments, .about-education {
    margin-top: 2em;
  }
  
  /*.navbar-fixed-bottom {
    background: black;
  }*/

  #communicator_button, #about_creators_button, #achievments_button, #education_button, #games_button, #info_button, #settings_button, #shop_button, #logout_button {
    appearance: none;
    -webkit-appearance: none;
    -moz-appearance: none;
    outline: none;
    border: 0;
    background: transparent;
    color: white;    
  }

  #communicator_button, #about_creators_button, #achievments_button, #education_button, #games_button, #info_button, #settings_button, #shop_button {
    font-size: 30px;
  }
  #logout_button {
    margin-top: 5px;
  }


</style>