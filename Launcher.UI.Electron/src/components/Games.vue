<template>
  <div>
    <div class="col-md-4"></div>
    <div class="col-md-4">
      <button type="button" id="logout_button" name="logout_button" class="btn btn-primary btn-lg" v-on:click="OnMiniMenuClicked">
        <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
      </button>
    </div>
    <div class="col-md-4"></div>
    
  </div>

</template>

<script lang="ts">
  import Vue from 'vue'
  import Component from 'vue-class-component'
  import { iocContainer } from '../inversify.config'
  import { IGamesService } from '../services/games.service'
  import { TYPES } from '../RegitredTypes'

  interface IGamesComponent {
    OnMiniMenuClicked(): void;
  }

  class GamesModel {

  }

  @Component
  export default class GamesComponent extends Vue implements IGamesComponent {


    OnMiniMenuClicked(): void {
      alert("Kliknales Mini Menu");
    }


  }


</script>

<style>

 
</style>