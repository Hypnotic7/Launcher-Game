<template>
  <div id="app"> 
    <div class="container-fluid">
      <div id="title-bar"></div>  
      
      <div id="title-bar-btns">
        <div class="row">
          <div class="col-md-7"></div>
          <div class="col-md-5">
            <button type="button" id="close-btn" class="btn btn-primary btn-lg" v-on:click="Close">
              <span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
            </button>
            <button type="button" id="max-btn" class="btn btn-primary btn-lg" v-on:click="Maximize">
              <span class="glyphicon glyphicon-fullscreen" aria-hidden="true"></span>
            </button>
            <button type="button" id="min-btn" class="btn btn-primary btn-lg" v-on:click="Minimize">
              <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
            </button>
          </div>
          
        </div>
      </div>
      <router-view></router-view>
      </div>
    </div>
</template>

<script lang="ts">
  import Vue from 'vue'
  import Component from 'vue-class-component'

  declare const window: any;
  const electron = window.require('electron');

  @Component
  export default class App extends Vue{

    Minimize(): void {
      electron.remote.getCurrentWindow().minimize();
    }

    Maximize(): void {
      electron.remote.getCurrentWindow().maximize();

    }

    Close(): void {
      electron.remote.getCurrentWindow().close();

    }
}
</script>

<style>
    #app {
      font - family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
