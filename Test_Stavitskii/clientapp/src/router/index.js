import Vue from 'vue'
import Router from 'vue-router'
import Order from "../views/Order.vue";

Vue.use(Router)

export default new Router({
    mode: 'history',
    routes: [
        {
            path: '/',
            name: '',
            component: Order,
        },
        {
            path:"/Order",
            name:'Order',
            component: Order,
        },
    ]
})