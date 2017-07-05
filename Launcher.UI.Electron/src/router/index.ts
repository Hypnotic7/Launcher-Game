import Vue from 'vue'
import Router, { RouterOptions } from 'vue-router'
import LoginComponent from '../components/Login.vue'
import CreateAccountComponent from '../components/Account.vue'

const routerOpt = <RouterOptions>{
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
};

const router = new Router(routerOpt)

Vue.use(Router)

export default router
