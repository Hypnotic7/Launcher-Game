import Vue from 'vue'
import Router from 'vue-router'
import LoginComponent from '../components/Login.vue'
import CreateAccountComponent from '../components/Account.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Login',
      component: LoginComponent
    },
    {
      path: '/CreateAccount',
      name: 'createAccount',
      component: CreateAccountComponent
    }
  ]
})
