import Vue from 'vue'
import Router, { RouterOptions } from 'vue-router'
import LoginComponent from '../components/Login.vue'
import CreateAccountComponent from '../components/Account.vue'
import MainMenuComponent from '../components/MainMenu.vue'
import GameComponent from '../components/Game.vue'

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
        },
        {
            path: '/MainMenu',
            name: 'mainMenu',
            component: MainMenuComponent
        },
        {
            path: '/Game',
            name: 'Game',
            component: GameComponent
        }
    ]
};

const router = new Router(routerOpt)

Vue.use(Router)

export default router
