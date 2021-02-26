<template>
    <div>
        <OrderList :data="Order"  />
        <v-overlay :value="overlay" opacity="0.7">
            <v-progress-circular indeterminate size="64"></v-progress-circular>
        </v-overlay>
    </div>
</template>

<script>
    import OrderList from "../components/OrderList";

    export default {
        name: "Order",
        components: {
            OrderList,
        },
        data() {
            return {
                Order:[],
                overlay: false,
            }
        },

        mounted() {
            this.getUsers();
        },
        methods: {
            async getUsers() {
                await this.axios.get('http://localhost:5000/api/listoforders')
                    .then(response => {
                        if (response) {
                            this.Order = [...response.data];
                            this.overlay = false;

                        }
                        else{
                            alert('response null')
                        }
                    })
            },
        },
    }
</script>

<style scoped>

</style>