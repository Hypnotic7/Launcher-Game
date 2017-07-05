// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue, { ComponentOptions } from 'vue'
import App from './App.vue'
import router from './router'

Vue.config.productionTip = false;

const vueComponent = <ComponentOptions<Vue>>{
    el: '#app',
    router: router,
    template: '<App/>',
    components: { App }
};

/* eslint-disable no-new */
window.onload = () => {
    new Vue(vueComponent);
};
