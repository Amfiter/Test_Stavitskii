<template>

  <v-app>
    <v-responsive :aspect-ratio="16/9">
      <div id="app">
        <v-app-bar
                color="green"
                dark
                height="50"
        >
          <v-app-bar-nav-icon @click="drawer = true"></v-app-bar-nav-icon>
          <v-col
                  cols="1"
          >
            <v-toolbar-title style="font-size: 2em;">Test</v-toolbar-title>
          </v-col>
          <!--search-->
          <Search/>
        </v-app-bar>
        <!--bar-->
        <v-navigation-drawer
                v-model="drawer"
                absolute
                temporary
        >
          <v-list
                  nav
                  dense
          >
            <v-list-item-group
                    active-class="deep-purple--text text--accent-4"

            >
              <v-list-item :to ="{name: 'Order'}">
                <v-list-item-icon>
                  <v-icon>mdi-call-split</v-icon>
                </v-list-item-icon>
                <v-list-item-title>Order</v-list-item-title>

              </v-list-item>


            </v-list-item-group>
          </v-list>
        </v-navigation-drawer>
        <v-main>
          <router-view/>
        </v-main>

      </div>
      <!--footer-->
      <v-footer
              color="green"
              absolute
              class="font-weight-medium"
      >
        <v-col style="color: aliceblue"
               class="text-center"
               cols="12"
        >
          {{ new Date() }} — Vladimir
        </v-col>

      </v-footer>

    </v-responsive>
  </v-app>

</template>

<script>
  export default {
    name: 'App',
    data:() =>({
      drawer: false,
      
    })
  };
</script>
