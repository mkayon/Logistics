using System;
using System.ComponentModel;

namespace Logistics.Models.Orders
{
    public class OrderSummaryViewModel
    {
        public string ContactPersonName { get; internal set; }
        public string ContactPersonPhone { get; internal set; }
        public string ContractNumber { get; internal set; }
        public DateTime CreateDate { get; internal set; }
        public string NbuRateDate { get; internal set; }
        public string OrderNumber { get; internal set; }
        public string OrderpPriceUah { get; internal set; }
        public string OrderpPriceUsd { get; internal set; }
        public string OrderStatus { get; internal set; }
        public string OrganizationName { get; internal set; }
        public string PaymentStatus { get; internal set; }
    }
}