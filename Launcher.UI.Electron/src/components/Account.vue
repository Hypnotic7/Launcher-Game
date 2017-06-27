<template>
  <p>asdasdasdasdasdasdsadasdasdasdsadsadasd</p>
</template>

<script lang="ts">

  import Vue from 'vue'
  import Component from 'vue-class-component'
  import { CreateAccountService } from '../services/create.account.service';
  import { iocContainer } from '../inversify.config'


    export class CreateAccountModel {
        accountName: string;
        password: string;
        email: string;
    }

    @Component
    export default class CreateAccountComponent extends Vue
    {
        CreateAccountModel: CreateAccountModel = new CreateAccountModel();
        CreateAccountService: CreateAccountService = new CreateAccountService();
    }
</script>

<style>

</style>