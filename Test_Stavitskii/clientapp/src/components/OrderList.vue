<template>
    <v-card flat
            style="margin-top: 1em">
        <v-overlay :value="overlay" opacity="0.7">
            <v-progress-circular indeterminate size="64"></v-progress-circular>
        </v-overlay>
        
        <v-data-table
                :headers="headersOrderKey"
                :items="data"
                :page.sync="page"
                :expanded.sync="expanded"
                show-expand
                :items-per-page="itemsPerPage"
                hide-default-footer
                @page-count="pageCount = $event"
                style="margin-bottom: 1em;margin-left: 1em;margin-right: 1em; margin-top: 1em;"
        >
            <template v-slot:expanded-item="{ headers, item }">
               
               
                <td :colspan="3" v-if="item && item.deliveryAddress">
                    <br>
                    <tr>  <strong>zipCode:</strong> {{ item.deliveryAddress.zipCode }}</tr>
                    <tr>   <strong>addressLine1:</strong> {{ item.deliveryAddress.addressLine1 }}</tr>
                    <tr>   <strong>addressLine2:</strong> {{ item.deliveryAddress.addressLine2 }}</tr>
                    <tr>  <strong> description:</strong> {{ item.deliveryAddress.description }}</tr>
                    <tr>  <strong> city:</strong> {{ item.deliveryAddress.city }}</tr>
                    <tr>  <strong> country:</strong> {{ item.deliveryAddress.country }}</tr>
                    <tr>  <strong> fullName:</strong> {{ item.deliveryAddress.fullName }}</tr>
                    <tr>  <strong> phone:</strong> {{ item.deliveryAddress.phone }}</tr>
                    <br>
                </td>
                <td  :colspan="2" v-if="item && item.shipping">
                    
                    <tr>  <strong>id:</strong> {{ item.shipping.id }}</tr>
                    <tr>  <strong> title:</strong> {{ item.shipping.title }}</tr>
                    <tr>  <strong> phone:</strong> {{ item.shipping.phone }}</tr>
                    <tr>  <strong> email:</strong> {{ item.shipping.email || '-' }}</tr>
                    <tr>   <strong>shippingType:</strong> {{ item.shipping.shippingType || '-' }}</tr>
                    <br>
                </td>
                <td v-else>Wait...</td>
                   
               
            </template>
        </v-data-table>
        <!--counter page-->
        <div style="margin-left: 1.5em;margin-right: 1.5em;margin-bottom: 3em;">
            <v-pagination v-model="page" :length="pageCount"></v-pagination>
            <v-text-field
                    :value="itemsPerPage"
                    label="Items per page"
                    type="number"
                    min="-1"
                    max="10"
                    @input="itemsPerPage = parseInt($event, 10)"
            ></v-text-field>
        </div>

    </v-card>
</template>

<script>
    export default {
        name: 'Order',
        props: {
            data: {
                type: Array,
                default:() => [],
            },
            value: {
                default: '',
            }
        },
        data: () => ({

            expanded: [],
            singleExpand: false,
            
            title:'Order',
            overlay: false,
            page: 1,
            pageCount: 0,
            itemsPerPage: 10,
            
            sheet: false,
            
            // структура ордеров
            Order:[
                {
                    id:  '',
                    customId:  '',
                    sourceOrderId:  '',
                    title:  '',
                    trackingUrl:  '',
                    trackingNumber: null,
                    status:  '',
                    renderStatus:  '',
                    paymentStatus:  '',
                    
                    
                    deliveryAddress: {
                        zipCode:  '',
                        addressLine1:  '',
                        addressLine2:  '',
                        description:  '',
                        city:  '',
                        country:  '',
                        fullName:  '',
                        phone:  ''
                    },
                    shipping: {
                        id: 0,
                        title:  '',
                        phone: null,
                        email:  '',
                        shippingType:  ''
                    },  
                    
                    commentsCount: 0,
                    downloadLink:  '',
                    previewImageUrl:  '',
                    price: 0.0,
                    discountPrice: 0,
                    deliveryPrice: 0.0,
                    totalPrice: 0.0,
                    userId: 0,
                    userCompanyAccountId: null,
                    discountId: 0,
                    discountTitle:  '',
                    dateCreated:  '',
                    dateModified:  '',
                    datePaid:  ''
                },
            ],

            
            headersOrderKey: [
                { text: '',align: 'start', value: 'data-table-expand' },
                {
                    text: 'Id',
                    
                    sortable: false,
                    value: 'id',
                },
                { text: 'CustomId', value: 'customId' },
                { text: 'SourceOrderId', value: 'sourceOrderId' },
                { text: 'Title ', value: 'title' },
                
                { text: 'Status ', value: 'status' },
                { text: 'RenderStatus ', value: 'renderStatus' },
                { text: 'PaymentStatus ', value: 'paymentStatus' },
                { text: 'СommentsCount ', value: 'commentsCount' },
                { text: 'DownloadLink ', value: 'downloadLink' },
                { text: 'PreviewImageUrl ', value: 'previewImageUrl' },
                { text: 'Price ', value: 'price' },
                { text: 'DiscountPrice ', value: 'discountPrice' },
                { text: 'DeliveryPrice ', value: 'deliveryPrice'},
                { text: 'TotalPrice ', value: 'totalPrice' },
                { text: 'UserId ', value: 'userId' },
                
                { text: 'DiscountTitle ', value: 'discountTitle' },
                { text: 'DateCreated ', value: 'dateCreated' },
                { text: 'DateModified ', value: 'dateModified' },
                { text: 'DatePaid ', value: 'datePaid' },
                { text: 'TrackingUrl ', value: 'trackingUrl' },
                { text: 'TrackingNumber ', value: 'trackingNumber' },
                { text: 'UserCompanyAccountId ', value: 'userCompanyAccountId' },
                { text: 'DiscountId ', value: 'discountId' },
            ],
        }),
        
    }
</script>



