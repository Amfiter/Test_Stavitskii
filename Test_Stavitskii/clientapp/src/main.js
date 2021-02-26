import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import vuetify from "./plugins/vuetify";
import global from "./plugins/global";
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios)

Vue.config.productionTip = false;

new Vue({
  router,
  vuetify,
  global,
  render: h => h(App)
}).$mount("#app");


