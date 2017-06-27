<template>
  <div id="app"> 
    <div class="container-fluid">
      <div id="title-bar"></div>      
      <div id="title-bar-btns">
        <button id="min-btn" class="btn btn-default btn-md" v-on:click="Minimize">
          <span class="glyphicon glyphicon-minus" aria-hidden="true">-</span>
        </button>
        <button id="max-btn" class="btn btn-default btn-md" v-on:click="Maximize">
          <span class="glyphicon glyphicon-fullscreen" aria-hidden="true">o</span>
        </button>
        <button id="close-btn" class="btn btn-default btn-md" v-on:click="Close">
          <span class="glyphicon glyphicon-remove" aria-hidden="true">x</span>
        </button>
      </div>
      <router-view></router-view>
      </div>
    </div>
</template>

<script lang="ts">
  import Vue from 'vue'
  import Component from 'vue-class-component'

  @Component
  export default class App extends Vue{

    Minimize(): void {

    }

    Maximize(): void {

    }

    Close(): void {
 
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
