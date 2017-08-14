<template>
  <div class="game-component">
    <div class="game-nav">
      <div class="row">
        <div class="col-md-4">
          <button type="button" id="game1_button" name="game1_button" class="btn btn-primary btn-lg btn-block" v-on:click="OnGameClicked">
            <span class="glyphicon 	glyphicon glyphicon-screenshot" aria-hidden="true"> Game 1</span>
          </button>
        </div>
        <div class="col-md-4">
          <button type="button" id="game2_button" name="game2_button" class="btn btn-primary btn-lg btn-block" v-on:click="OnGameClicked">
            <span class="glyphicon glyphicon glyphicon-fire" aria-hidden="true"> Game 2</span>
          </button>
        </div>
        <div class="col-md-4">
          <button type="button" id="game3_button" name="game3_button" class="btn btn-primary btn-lg btn-block" v-on:click="OnGameClicked">
            <span class="glyphicon glyphicon glyphicon-tower" aria-hidden="true"> Game 3</span>
          </button>
        </div>
      </div>
    </div>
    
      <div class="row">
        <div class="col-lg-4">
          <div class="square-service-block">
            <button type="button" id="game3_button" name="game3_button" class="btn btn-primary btn-lg btn-block" v-on:click="OnGameClicked">
              <div class="glyphicon glyphicon glyphicon-tower"><i class="fa fa-paint-brush" aria-hidden="true"></i></div>
              <h2 class="ssb-title">Install</h2>
            </button>
          </div>
        </div>
        <div class="col-md-8">
          <div class="progress">
            <div class="progress-bar progress-bar-striped active" role="progressbar" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100" style="width:100%">100%
            </div>
          </div>
        </div>
      </div>

      <nav class="navbar navbar-fixed-bottom">
        <div class="navbar-header">
          <div class="row">
            <div class="col-md-2">
              <router-link :to="{name:'mainMenu'}" tag="button" class="btn btn-primary btn-lg btn-block" id="back_to_main_menu_button" name="back_to_main_menu_button">
                <span class="glyphicon glyphicon-circle-arrow-left" aria-hidden="true"></span>
              </router-link>
            </div>
            <div class="col-md-1"></div>
            <div class="col-md-2">
              <button type="button" id="logout_button" name="logout_button" class="btn btn-primary btn-lg" v-on:click="OnLogoutClicked">
                <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
              </button>
            </div>
            <div class="col-md-7"></div>
          </div>
        </div>
      </nav>
    </div>
</template>

<script lang="ts">

    import Vue from 'vue'
    import Component from 'vue-class-component'
    import { GameService } from '../services/game.service';
    import { iocContainer } from '../inversify.config'

    interface IGameComponent {
      OnGameClicked(gameTitle: string): void;
      OnBackToMainMenu(): void;
      OnLogoutClicked(): void;
    }

    export class GameModel {


    }

    @Component
    export default class GameComponent extends Vue implements IGameComponent {
      gameModel: GameModel = new GameModel();
      gameService: GameService = new GameService();

      OnGameClicked(gameTitle: string): void {

      }

      OnBackToMainMenu(): void {

      }

      OnLogoutClicked(): void {

      }

    }


</script>

<style>
  #game1_button, #game2_button, #game3_button, #back_to_main_menu_button{
    appearance: none;
    -webkit-appearance: none;
    -moz-appearance: none;
    outline: none;   
    background: transparent;
    color: white;
    border: 0;
  }

  #game1_button, #game2_button, #game3_button {
    border: 1px solid white;
  }

  #back_to_main_menu_button{
    margin-top: 6px;
 
  }

  #back_to_main_menu_button, #logout_button {
    margin-right: 1.25em;
  }
</style>