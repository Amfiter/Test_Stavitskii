using System;
using System.Collections.Generic;

namespace Test_Stavitskii.Responses
{
    public class Orders
    {
         public string ApiVersion { get; set; }
         public List<Result> Result { get; set; }
         public int ResponseCode { get; set; }
    }

    public class Result
    {
        public string Id { get; set; }
        public float PhotolabId { get; set; }
        public string CustomId { get; set; }
        public string SourceOrderId { get; set; }
        public string ManagerId {get;set;}
        public string AssignedToId {get;set;}
        public string Title {get;set;}
        public string TrackingUrl {get;set;}
        public string TrackingNumber { get; set; }
        public string Status {get;set;}
        public string RenderStatus {get;set;}
        public string PaymentStatus {get;set;}
        public DeliveryAddress DeliveryAddress {get;set;}
        public Shipping Shipping {get;set;}
        public float CommentsCount {get;set;}
        public string DownloadLink {get;set;}
        public string PreviewImageUrl {get;set;}
        public float Price {get;set;}
        public float DiscountPrice {get;set;}
        public float DeliveryPrice {get;set;}
        public float TotalPrice {get;set;}
        public float PaidPrice {get;set;}
        public float UserId {get;set;}
        public string UserCompanyAccountId {get;set;}
        public string DiscountTitle {get;set;}
        public string DateCreated {get;set;}
        public string DateModified {get;set;}
        public string DatePaid {get;set;}
        public string LastDownloadedPaymentDocument {get;set;}
        public string PaymentSystemUniqueId {get;set;}
        public string GoogleClientId {get;set;}
        public string ContractorOrderNumber {get;set;}
        public float ContractorOrderTotalPrice {get;set;}
    }
    public class DeliveryAddress
    {
        public string ZipCode {get;set;}
        public string AddressLine1 {get;set;}
        public string AddressLine2 {get;set;}
        public string Description {get;set;}
        public string City {get;set;}
        public string Country {get;set;}
        public string State {get;set;}
        public string FullName {get;set;}
        public string Phone {get;set;}
    }
    public class Shipping
    {
        public float Id {get;set;}
        public string Title {get;set;}
        public string Phone {get;set;}
        public string Email {get;set;}
        public string Type {get;set;}
    }
}