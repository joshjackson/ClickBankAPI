using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickBankAPI {
    using Grpc.Net.Client.Balancer;
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class OrderData {
        public DateTime? TransactionTime { get; set; }
        public string? Receipt { get; set; }
        public string? TrackingId { get; set; }
        public string? PaymentMethod { get; set; }
        public string? TransactionType { get; set; }
        public decimal? TotalOrderAmount { get; set; }
        public decimal? TotalShippingAmount { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public string? Vendor { get; set; }
        public string? Affiliate { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Currency { get; set; }
        public bool? DeclinedConsent { get; set; }
        public string? Email { get; set; }
        public string? PostalCode { get; set; }
        public List<ContactField>? CustomerContactInfo { get; set; }
        public string? Role { get; set; }
        public string? FullName { get; set; }
        public RefundableState? CustomerRefundableState { get; set; }
        public VendorVariableElementArray? VendorVariables { get; set; }
        public List<LineItemData>? LineItemData { get; set; }
        public CommonTrackingParameters? CommonTrackingParameters { get; set; }
        public AffiliateTrackingParameters? AffiliateTrackingParameters { get; set; }
    }

    public class ContactField {
        public string? Field { get; set; }
        public string? Value { get; set; }
    }

    public class VendorVariableElementArray {
        public List<VendorVariableElement>? Items { get; set; }
    }

    public class LineItemData {
        public string? ItemNo { get; set; }
        public string? ProductTitle { get; set; }
        public bool? Recurring { get; set; }
        public bool? Shippable { get; set; }
        public decimal? CustomerAmount { get; set; }
        public decimal? AccountAmount { get; set; }
        public int? Quantity { get; set; }
        public string? LineItemType { get; set; }
        public bool? RefundsBlocked { get; set; }
        public decimal? RebillAmount { get; set; }
        public int? ProcessedPayments { get; set; }
        public int? FuturePayments { get; set; }
        public DateTime? NextPaymentDate { get; set; }
        public string? Status { get; set; }
        public string? Role { get; set; }
    }

    public class CommonTrackingParameters {
        public string? ClickTimestamp { get; set; }
        public string? ClickId { get; set; }
        public string? UserAgent { get; set; }
        public string? DeviceType { get; set; }
        public string? DeviceBrand { get; set; }
        public string? DeviceModel { get; set; }
        public string? OS { get; set; }
        public string? OSVersion { get; set; }
        public string? Browser { get; set; }
        public string? BrowserVersion { get; set; }
        public string? BrowserLang { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? CBPage { get; set; }
        public string? TrackingType { get; set; }
    }

    public class AffiliateTrackingParameters {
        public string? Offer { get; set; }
        public string? TrafficType { get; set; }
        public string? TrafficSource { get; set; }
        public string? Campaign { get; set; }
        public string? AdGroup { get; set; }
        public string? Ad { get; set; }
        public string? Creative { get; set; }
        public string? ExtClid { get; set; }
        public string? Fbclid { get; set; }
        public string? AffSub1 { get; set; }
        public string? AffSub2 { get; set; }
        public string? AffSub3 { get; set; }
        public string? AffSub4 { get; set; }
        public string? AffSub5 { get; set; }
        public string? UniqueAffSub1 { get; set; }
        public string? UniqueAffSub2 { get; set; }
        public string? UniqueAffSub3 { get; set; }
        public string? UniqueAffSub4 { get; set; }
        public string? UniqueAffSub5 { get; set; }
        public string? ContactId { get; set; }
    }

    public class ChangeProductRequestParameters {
        public string oldSku { get; set; } = string.Empty;
        public string newSku { get; set; } = string.Empty;
        public bool? carryAffiliate { get; set; }
        public bool applyProratedRefund { get; set; } = true;
        public string? nextRebillDate { get; set; }
    }

    public class OrderCountRequestParameters {
        public string? startDate { get; set; }
        public string? endDate { get; set; }
        public string? type { get; set; }
        public string? vendor { get; set; }
        public string? affiliate { get; set; }
        public string? lastName { get; set; }
        public string? item { get; set; }
        public string? email { get; set; }
        public string? tid { get; set; }
        public string? postalCode { get; set; }
        public string? role { get; set; }
    }

    public class OrderChangeAddressRequestParameters {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? address1 { get; set; }
        public string? address2 { get; set; }
        public string? city { get; set; }
        public string? county { get; set; }
        public string? province { get; set; }
        public string? countryCode { get; set; }
        public string? postalCode { get; set; }
    }

    public enum RefundableState {
        REFUNDABLE,
        SUGGESTED_REFUND_BLOCK,
        UNREFUNDABLE,
        ALREADY_REFUNDED,
        TOO_OLD,
        REFUND_BLOCKED,
        HAS_OPEN_REFUND,
        OVER_ELV_LIMIT,
        PROVIDER_DISCONNECTED
    }


    public class Orders {



        public Orders() { }
        public Orders(string id) { }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        /// <summary>
        /// Allows a vendor to restart a cancelled subscription
        /// </summary>
        /// <param name="Receipt">Original Order Receipt ID</param>
        /// <param name="sku">The item number of the subscription product that should be reinstated for the order</param>
        public void Reinstate(string Receipt, string? sku = null) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Receipt">Original Order Receipt ID</param>
        /// <param name="RestartDate">The date when the subscription will be resumed in format yyyy-mm-dd</param>
        /// <param name="sku">The item number of the subscription product that should be reinstated for the order</param>
        public void Pause(string Receipt, DateTime RestartDate, string sku) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Receipt">Original Order Receipt ID</param>
        /// <param name="NumPeriods"></param>
        /// <param name="sku">The item number of the subscription product that should be reinstated for the order</param>
        public void Extend(string Receipt, int NumPeriods, string sku) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Receipt">Original Order Receipt ID</param>
        /// <param name="reqParams"></param>
        public void ChangeProduct(string Receipt, ChangeProductRequestParameters reqParams) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Receipt">Original Order Receipt ID</param>
        public void ChangeAddress (string Receipt) {  } 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqParams"></param>
        /// <returns></returns>
        public int OrderCount(OrderCountRequestParameters reqParams) { return 0; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<OrderData>? OrderList() { return new List<OrderData>(); }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Receipt">Original Order Receipt ID</param>
        /// <returns></returns>
        public OrderData? GetOrder(string Receipt) {  return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Receipt">Original Order Receipt ID</param>
        /// <returns></returns>
        public List<OrderData>? Upsells (string Receipt) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Receipt">Original Order Receipt ID</param>
        /// <param name="changeDate"></param>
        /// <param name="sku">The item number of the subscription product that should be reinstated for the order</param>
        public void ChangeDate(string Receipt, DateTime changeDate, string? sku = "") { }
    }
}
